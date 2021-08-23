using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Billing.App.Extensions;
using Billing.App.Handlers;
using Billing.App.Routes;
using Billing.Service.Authentication;
using Billing.Service.Responses;
using Billing.Shared.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Billing.App.Controllers
{
    public class AppController : Controller
    {
        private IAuth mAuth;
        private FileHandler fileHandler;

        public AppController(IAuth mAuth, FileHandler fileHandler)
        {
            this.mAuth = mAuth;
            this.fileHandler = fileHandler;
        }

        public IActionResult Index()
            => Redirect("/index.html");

        [HttpPost(WebRoutes.SignIn)]
        public async Task<IActionResult> SignIn([FromBody] SignInModel model)
        {
            if (model == null)
                return BadRequest("O Modelo não pode ser nulo.");

            // Signing in
            return Ok(await mAuth.SignIn(new SignInModel
            {
                User = model.User,
                Password = model.Password
            }));
        }

        [HttpPost(WebRoutes.SignUp)]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                var errors = new Dictionary<string, string>();
                foreach (var key in ModelState.Keys)
                {
                    var value = ModelState.GetValueOrDefault(key);
                    foreach (var error in value.Errors)
                        errors.Add(key, error.ErrorMessage);
                }

                return BadRequest(new AuthResponse
                {
                    Errors = errors.Select(s => $"key: {s.Key}, error: {s.Value}").ToList()
                });
            }

            // Sigining up
            return Ok(await mAuth.SignUp(model, model.Password));
        }

        [Authorize]
        [HttpGet(WebRoutes.Account)]
        public async Task<IActionResult> Account()
        {
            var id = HttpContext.GetUserId();
            if (id == null)
                return Ok(new Response
                {
                    Errors = new List<string> { "Deve estar Logado para realizar esta operação" }
                });

            var result = await mAuth.Account(id);
            if (!result.Success)
                return Ok(new Response
                {
                    Errors = result.Errors.ToList()
                });

            // Get Logged user info
            return Ok(result);
        }

        [Authorize]
        [HttpPut(WebRoutes.ChangeRoles)]
        public async Task<IActionResult> ChangeRoles(string id, [FromBody] string[] roles)
        {
            return Ok(await mAuth.ChangeRoles(id, roles));
        }

        [Authorize]
        [HttpPut(WebRoutes.ChangePassword)]
        public async Task<IActionResult> ChangePassword([FromBody] PasswordModel model)
        {
            return Ok(await mAuth.ChangePassword(HttpContext.GetUserId(), model.Current, model.New));
        }

        [Authorize]
        [HttpPut(WebRoutes.ChangeUserInfo)]
        public async Task<IActionResult> ChangeUserInfo(string id, [FromBody] SignUpModel model)
        {
            return Ok(await mAuth.ChangeUserInfo(id, model));
        }

        [HttpGet(WebRoutes.Roles)]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await Task.FromResult(new Response
            {
                Data = typeof(AppRoles).GetFields()
                    .Select(role => role.GetValue(role) as string)
                    .ToList()
            }));
        }

        [Authorize]
        [HttpGet(WebRoutes.UserRoles)]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            return Ok(await mAuth.UserRoles(userId));
        }

        // [Authorize]
        [HttpGet(WebRoutes.Download)]
        public async Task<IActionResult> Download(string folderName, string fileName)
        {
            var file = $"{fileHandler.Folder(folderName).folderPath}{fileName}";   

            // IF file does no exist
            if (!System.IO.File.Exists(file))
                return NotFound();
            
            // Get all the data as bytes
            var dataBytes = await System.IO.File.ReadAllBytesAsync(file);

            // If the bytes is empty 
            if (dataBytes.Count() == 0)
                return NoContent();

            // Stream out the data
            return File(dataBytes, MimeTypeMapping.Get(fileName.ToExtension()));
        }
    }
}

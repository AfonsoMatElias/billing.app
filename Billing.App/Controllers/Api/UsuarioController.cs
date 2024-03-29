using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billing.App.Routes;
using Billing.Service.Dto;
using Billing.App.Models;
using Billing.Service.Services.Interfaces;
using Billing.Service.Responses;
using Billing.Service.Pageable;

namespace Billing.App.Controllers.Api
{
    [Route(ApiRoutes.Base)]
    [ApiController]
    // [Authorize]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService service = null;

        public UsuarioController(IUsuarioService service)
        {
            this.service = service;
        }

        // GET: api/Usuario
        [HttpGet]
        public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
        {
            var dbData = await service.FindAll(pageableQuery);

            return new Response
            {
                Data = dbData.Data,
                Pagination = dbData.Pageable,
                Message = "Listed"
            };
        }

        // GET: api/Usuario/5:12837918237
        [HttpGet("{uid}")]
        public async Task<Response> Get(string uid)
        {
            var dbData = await service.FindById(uid);

            return new Response
            {
                Data = dbData,
                Message = "Response Object",
                Errors = dbData == null ? new[] { "Not Found" } : new string[] { }
            };
        }

        // POST: api/Usuario
        [HttpPost]
        public async Task<Response> Post([FromBody] UsuarioDto model)
        {
            return await Task.FromResult(new Response 
            {
                Message = "Invalid Operation"
            });

            // try
            // {
            //     if (model == null)
            //         throw new AppException("Objecto inválido!", true);

            //     await service.Save(model);

            //     return new Response { Message = "Created" };
            // }
            // catch (AppException ex)
            // {
            //     return new Response
            //     {
            //         Errors = ex.Errors
            //     };
            // }
        }

        // PUT: api/Usuario/5:12837918237
        [HttpPut("{uid}")]
        public async Task<Response> Put(string uid, [FromBody] UsuarioDto model)
        {
            return await Task.FromResult(new Response 
            {
                Message = "Invalid Operation"
            });

            // try
            // {
            //     if (model == null)
            //         throw new AppException("Objecto inválido!", true);

            //     await service.Update(uid, model);
             
            //     return new Response { Message = "Updated" };
            // }
            // catch (AppException ex)
            // {
            //     return new Response
            //     {
            //         Errors = ex.Errors
            //     };
            // }
        }

        // DELETE: api/Usuario/5:12837918237
        [HttpDelete("{uid}")]
        public async Task<Response> Delete(string uid)
        {
            return await Task.FromResult(new Response 
            {
                Message = "Invalid Operation"
            });
            
            // try
            // {
            //     await service.Remove(uid);
            
            //     return new Response { Message = "Deleted" };
            // }
            // catch (AppException ex)
            // {
            //     return new Response
            //     {
            //         Errors = ex.Errors
            //     };
            // }
        }
    }
}
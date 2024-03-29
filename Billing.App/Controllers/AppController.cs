﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Billing.App.Extensions;
using Billing.App.Handlers;
using Billing.App.Routes;
using Billing.Service.Authentication;
using Billing.Service.Data;
using Billing.Service.Extensions;
using Billing.Service.Models.Base;
using Billing.Service.Responses;
using Billing.Shared.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Billing.App.Controllers
{
	public class AppController : Controller
	{
		private readonly IAuth mAuth;
		private readonly DataContext context;
		private readonly PreferenceHandler preferenceHandler;

		public AppController(IAuth mAuth, DataContext context, PreferenceHandler preferenceHandler)
		{
			this.mAuth = mAuth;
			this.context = context;
			this.preferenceHandler = preferenceHandler;
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

			var userName = result.Data.UserName;

			try
			{
				if (!this.preferenceHandler.HasPreferences(userName))
				{
					// Creating the preferencies
					this.preferenceHandler.InitPreferences(userName);
					await this.preferenceHandler.Save();
				}

				result.Data.Preferences = await this.preferenceHandler.Get(userName);
			}
			catch (AppException)
			{
				Debugger.Log(0, "Preferences Exception", $"Couldn't create preferences for {userName}");
			}

			// Get Logged user info
			return Ok(result);
		}

		[Authorize]
		[HttpPut(WebRoutes.ChangePreference)]
		public async Task<IActionResult> ChangeRoles(string prefName, [FromQuery] string prefValue)
		{
			var userName = this.HttpContext.GetKey("name");

			if (prefValue == null)
				return Ok(new Response
				{
					Errors = new[] { "Invalid value provided" }
				});

			await this.preferenceHandler.Set(userName, prefName, prefValue);

			await this.preferenceHandler.Save();

			return Ok(new Response
			{
				Data = true,
				Message = "Updated"
			});
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
					.Where(x => x != AppRoles.superadmin)
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
		public async Task<IActionResult> Download(string source, string uniqueName)
		{
			if (source is null)
				return NotFound();
			
			if (uniqueName is null)
				return NotFound();

			// Getting the DataContext DbSet property
			var dbSetProperty = this.context.GetType().GetProperties()
				.FirstOrDefault(x => x.Name.ToLower() == source.ToLower());

			var _table = this.context.Model.GetEntityTypes().FirstOrDefault(x => 
				x.GetTableName().ToLower() == source.ToLower()
			);

			if (_table == null)
				return BadRequest("Invalid source");

			// Getting the table name
			var tableName = _table.GetTableName();

			var dbResult = (await this.context.ExecuteAsync(
				$"SELECT [Content] from [dbo].[{tableName}] where UniqueName='{uniqueName}'"
			)).FirstOrDefault();

			// If file does no exist
			if (dbResult == null)
				return NotFound();

			// Get all the data as bytes
			var dataBytes = dbResult["Content"] as byte[];

			// If the bytes is empty 
			if (dataBytes.Count() == 0)
				return NoContent();

			// Stream out the data
			return File(dataBytes, MimeTypeMapping.Get(uniqueName.ToExtension()));
		}
	}
}

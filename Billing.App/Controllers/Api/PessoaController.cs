using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billing.App.Routes;
using Billing.Service.Dto;
using Billing.App.Models;
using Billing.Service.Services.Interfaces;
using Billing.Service.Responses;
using System.Linq;
using Billing.Service.Authentication;
using Microsoft.AspNetCore.Identity;
using Billing.Service.Models;
using Billing.App.Handlers;
using System;
using Billing.Service.Pageable;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Billing.App.Controllers.Api
{
	[Route(ApiRoutes.Base)]
	[ApiController]
	// [Authorize]
	public class PessoaController : ControllerBase
	{
		private FileHandler fileHandler = null;
		private IPessoaService service = null;
		private UserManager<Usuario> userManager;

		public PessoaController(IPessoaService service, UserManager<Usuario> userManager, FileHandler fileHandler)
		{
			this.service = service;
			this.userManager = userManager;
			this.fileHandler = fileHandler;
		}

		// GET: api/Pessoa
		[HttpGet]
		public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
		{
			var dbData = await service.FindAll(Pagination.Of(pageableQuery.Page, pageableQuery.Size), queryable =>
			{
				queryable = queryable.Include(x => x.Genero)
										.Include(x => x.Titulo)
										.Where(x => x.Entidade == null);

				return queryable;
			});

			return new Response
			{
				Data = dbData.Data,
				Pagination = dbData.Pageable,
				Message = "Listed"
			};
		}

		// GET: api/Pessoa/5:12837918237
		[HttpGet("{uid}")]
		public async Task<Response> Get(string uid)
		{
			var dbData = await service.FindById(uid, queryable =>
			{

				queryable = queryable.Include(x => x.Contactos)
										.ThenInclude(x => x.TipoContacto);

				return queryable;
			});

			return new Response
			{
				Data = dbData,
				Message = "Response Object",
				Errors = dbData == null ? new[] { "Not Found" } : new string[] { }
			};
		}

		// POST: api/Pessoa
		[HttpPost]
		public async Task<Response> Post([FromForm] Attachment model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			var builtModel = model.Build<PessoaDto>();
			var hasPhoto = model.File != null;
			var fileName = "";

			if (hasPhoto)
			{
				fileName = $"{ Guid.NewGuid().ToString("N") }.{ model.File.ToExtension() }";
				builtModel.ProfileImageUrl = $"/download/pessoa/{fileName}";
			}

			await service.Save(builtModel).ContinueWith(async then =>
			{
				if (hasPhoto)
					await fileHandler.Folder("pessoa").SaveAsync(model.File, fileName);
			});
			
			return new Response { Message = "Created" };
		}

		// PUT: api/Pessoa/5:12837918237
		[HttpPut("{uid}")]
		public async Task<Response> Put(string uid, [FromForm] Attachment model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			var builtModel = model.Build<PessoaDto>();

			var fileName = "";
			var hasPhoto = model.File != null;
			bool toRemove = model.ToRemove == true && builtModel.ProfileImageUrl != null;

			if (hasPhoto && builtModel.ProfileImageUrl == null)
			{
				fileName = $"{ Guid.NewGuid().ToString("N") }.{ model.File.ToExtension() }";
				builtModel.ProfileImageUrl = $"/download/pessoa/{fileName}";
			}

			if (toRemove) {
				fileName = builtModel.ProfileImageUrl.Replace("/download/pessoa/", "");
				builtModel.ProfileImageUrl = "";
			}

			await service.Update(uid, builtModel).ContinueWith(async then =>
			{
				if (hasPhoto)
					await fileHandler.Folder("pessoa").SaveAsync(model.File, fileName);
				else if (toRemove)
					await fileHandler.Folder("pessoa").DeleteAsync(fileName);
			});

			return new Response { Message = "Updated" };
		}

		// DELETE: api/Pessoa/5:12837918237
		[HttpDelete("{uid}")]
		public async Task<Response> Delete(string uid)
		{
			await service.Remove(uid);
			return new Response { Message = "Deleted" };
		}
	}
}
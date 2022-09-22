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
		private IPessoaService service = null;
		private IPessoaImagemService pessoaImagemService = null;
		private UserManager<Usuario> userManager;

		public PessoaController(IPessoaService service, UserManager<Usuario> userManager, IPessoaImagemService pessoaImagemService)
		{
			this.service = service;
			this.userManager = userManager;
			this.pessoaImagemService = pessoaImagemService;
		}

		// GET: api/Pessoa
		[HttpGet]
		public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
		{
			var dbData = await service.FindAll(pageableQuery, queryable =>
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

			var hasPhoto = model.File != null;

			var builtModel = model.Compile<PessoaDto>((model, fileBytes, fileForm) =>
			{
				if (fileBytes == null || fileForm == null)
					return;

				model.PessoaImagem = new PessoaImagemDto
				{
					Content = fileBytes,
					Extension = fileForm.FileName.ToExtension(),
					Name = fileForm.FileName,
					UniqueName = Guid.NewGuid().ToString("N"),
				};
			});

			await service.Save(builtModel);

			return new Response { Message = "Created" };
		}

		// PUT: api/Pessoa/5:12837918237
		[HttpPut("{uid}")]
		public async Task<Response> Put(string uid, [FromForm] PessoaDto model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			await service.Update(uid, model);

			return new Response { Message = "Updated" };
		}

		// PUT: api/Pessoa/5:12837918237
		[HttpPut("{uid}")]
		public async Task<Response> PutImages(string uid, [FromForm] Attachment model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			var pessoa = await service.FindById(uid);

			if (pessoa == null)
				throw new AppException("Registro não encontrado!", true);

			PessoaImagemDto fileToSave = null;
			var filesToRemove = model.Compile<long[]>((model, fileBytes, fileForm) =>
				{
					fileToSave = new PessoaImagemDto
					{
						Content = fileBytes,
						Extension = fileForm.FileName.ToExtension(),
						Name = fileForm.FileName,
						UniqueName = Guid.NewGuid().ToString("N"),
						PessoaId = pessoa.Id
					};
				});

			// Removing all the requested images
			await pessoaImagemService.RemoveMany(filesToRemove);

			// Saving all the new images
			await pessoaImagemService.Save(fileToSave);

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
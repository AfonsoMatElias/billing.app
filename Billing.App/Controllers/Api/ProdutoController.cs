using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billing.App.Routes;
using Billing.Service.Dto;
using Billing.App.Models;
using Billing.Service.Services.Interfaces;
using Billing.Service.Responses;
using System.Linq;
using System;
using System.Collections.Generic;
using Billing.App.Handlers;
using Billing.App.Extensions;
using Microsoft.EntityFrameworkCore;
using Billing.Service.Pageable;
using Billing.Service.Models;

namespace Billing.App.Controllers.Api
{
	[Route(ApiRoutes.Base)]
	[ApiController]
	// [Authorize]
	public class ProdutoController : ControllerBase
	{
		private IProdutoService service = null;
		private IFuncionarioService funcionarioService = null;
		private IProdutoImagemService produtoImagemService = null;

		public ProdutoController(
			IProdutoService service,
			IFuncionarioService funcionarioService,
			IProdutoImagemService produtoImagemService
		)
		{
			this.service = service;
			this.funcionarioService = funcionarioService;
			this.produtoImagemService = produtoImagemService;
		}

		// GET: api/Produto
		[HttpGet]
		public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
		{
			try
			{
				var dbData = await service.FindAll(pageableQuery,
					queryable => queryable.Include(x => x.ProdutoImagens)
										  .Include(x => x.SubCategoria));

				return new Response
				{
					Data = dbData.Data,
					Pagination = dbData.Pageable,
					Message = "Listed"
				};
			}
			catch (AppException ex)
			{
				return new Response
				{
					Errors = ex.Errors
				};
			}
		}

		// GET: api/Produto/WithStock
		[HttpGet("WithStock")]
		public async Task<Response> GetWithStock([FromQuery] PageableQueryParam pageableQuery)
		{
			try
			{
				var dbData = await service.FindAll(pageableQuery,
					queryable => queryable.Include(x => x.ProdutoImagens)
										  .Include(x => x.Compras.Where(y => y.IsActiva)));

				return new Response
				{
					Data = dbData.Data,
					Pagination = dbData.Pageable,
					Message = "Listed"
				};
			}
			catch (AppException ex)
			{
				return new Response
				{
					Errors = ex.Errors
				};
			}
		}

		// GET: api/Produto/5:12837918237
		[HttpGet("{uid}")]
		public async Task<Response> Get(string uid)
		{
			try
			{
				var dbData = await service.FindById(uid,
					queryable => queryable.Include(x => x.ProdutoImagens)
										  .Include(x => x.SubCategoria));

				return new Response
				{
					Data = dbData,
					Message = "Response Object",
					Errors = dbData == null ? new[] { "Not Found" } : new string[] { }
				};
			}
			catch (AppException ex)
			{
				return new Response
				{
					Errors = ex.Errors
				};
			}
		}

		// POST: api/Produt
		[HttpPost]
		public async Task<Response> Post([FromForm] Attachments model)
		{
			try
			{
				if (model == null)
					throw new AppException("Objecto inválido!", true);

				var builtModel = model.Compile<ProdutoDto>((model, filesByte, filesForm) =>
				{
					model.ProdutoImagens = filesByte.Select((_bytes, index) => new ProdutoImagemDto
					{
						Content = _bytes,
						Extension = filesForm[index].FileName.ToExtension(),
						Name = filesForm[index].FileName,
						UniqueName = Guid.NewGuid().ToString("N"),
					}).ToList();
				});

				if (builtModel.Compras != null && builtModel.Compras.Any())
				{
					var compra = builtModel.Compras.FirstOrDefault();
					var userId = long.Parse(HttpContext.GetUserId());
					var funcionarioDto = await funcionarioService.Find(item => item.UsuarioId == userId);

					if (funcionarioDto == null)
						throw new AppException("Não tem permissão de criar um `Produto` com sua respectiva `Compra`", true);

					compra.EstabelecimentoId = funcionarioDto.EstabelecimentoId;
					compra.IsActiva = true;
				}

				await service.Save(builtModel);

				return new Response { Message = "Created" };
			}
			catch (AppException ex)
			{
				return new Response
				{
					Errors = ex.Errors
				};
			}
		}

		// PUT: api/Produto/5:12837918237
		[HttpPut("{uid}")]
		public async Task<Response> Put(string uid, [FromForm] ProdutoDto model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			await service.Update(uid, model);

			return new Response { Message = "Updated" };
		}

		// PUT: api/Produto/5:12837918237
		[HttpPut("UpdateImages/{uid}")]
		public async Task<Response> PutImages(string uid, [FromForm] Attachments model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			var product = await service.FindById(uid);

			if (product == null)
				throw new AppException("Registro não encontrado!", true);

			ProdutoImagemDto[] filesToSave = new ProdutoImagemDto[] { };
			var filesToRemove = model.Compile<long[]>((model, filesBytes, filesForm) =>
				{
					filesToSave = filesBytes.Select((_bytes, index) => new ProdutoImagemDto
					{
						Content = _bytes,
						Extension = filesForm[index].FileName.ToExtension(),
						Name = filesForm[index].FileName,
						UniqueName = Guid.NewGuid().ToString("N"),
						ProdutoId = product.Id
					}).ToArray();
				});

			// Removing all the requested images
			await produtoImagemService.RemoveMany(filesToRemove);

			// Saving all the new images
			await produtoImagemService.SaveMany(filesToSave);

			return new Response { Message = "Updated" };
		}

		// DELETE: api/Produto/5:12837918237
		[HttpDelete("{uid}")]
		public async Task<Response> Delete(string uid)
		{
			await service.Remove(uid);
			return new Response { Message = "Deleted" };
		}
	}
}
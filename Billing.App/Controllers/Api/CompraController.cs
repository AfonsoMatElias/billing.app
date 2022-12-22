using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billing.App.Routes;
using Billing.Service.Dto;
using Billing.App.Models;
using Billing.Service.Services.Interfaces;
using Billing.Service.Responses;
using Microsoft.AspNetCore.Authorization;
using Billing.Service.Pageable;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Billing.App.Controllers.Api
{
	[Route(ApiRoutes.Base)]
	[ApiController]
	// [Authorize]
	public class CompraController : ControllerBase
	{
		private ICompraService service = null;

		public CompraController(ICompraService service)
		{
			this.service = service;
		}

		// GET: api/Compra
		[HttpGet]
		public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery, [FromQuery] string search)
		{
			var dbData = await service.FindAll(pageableQuery, queryable =>
			{
				queryable = queryable.Include(x => x.Produto)
									 .Include(x => x.Fornecedor)
									 .Include(x => x.Seccao)
									 .Where(x => x.IsActiva)
									 .OrderBy(x => x.Quantidade);

				if (string.IsNullOrEmpty(search))
					return queryable;

				search = search.ToLower();

				queryable = queryable.Where(x => x.Produto.Nome.Contains(search) ||
							!string.IsNullOrEmpty(x.Produto.NomeSecundario) ? x.Produto.NomeSecundario.Contains(search) : false ||
							!string.IsNullOrEmpty(x.Produto.Descricao) ? x.Produto.Descricao.Contains(search) : false);

				return queryable;
			});

			return new Response
			{
				Data = dbData.Data,
				Pagination = dbData.Pageable,
				Message = "Listed"
			};
		}

		// GET: api/Compra/5:12837918237
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

		// POST: api/Compra
		[HttpPost]
		public async Task<Response> Post([FromBody] CompraDto model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			await service.Save(model);
			return new Response { Message = "Created" };
		}

		// POST: api/Compra
		[HttpPost("massive")]
		public async Task<Response> Post([FromBody] CompraDto[] model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			await service.SaveAll(model);
			return new Response { Message = "Created" };
		}

		// PUT: api/Compra/5:12837918237
		[HttpPut("{uid}")]
		public async Task<Response> Put(string uid, [FromBody] CompraDto model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			await service.Update(uid, model);
			return new Response { Message = "Updated" };
		}

		// DELETE: api/Compra/5:12837918237
		[HttpDelete("{uid}")]
		public async Task<Response> Delete(string uid)
		{
			await service.Remove(uid);
			return new Response { Message = "Deleted" };
		}
	}
}
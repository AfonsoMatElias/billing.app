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
	public class EntidadeController : ControllerBase
	{
		private IEntidadeService service = null;

		public EntidadeController(IEntidadeService service)
		{
			this.service = service;
		}

		// GET: api/Entidade
		[HttpGet]
		public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery,
										[FromQuery] string codigoTipoEntidade)
		{
			var dbData = await service.FindAll(pageableQuery, queryable =>
			{

				// Including the default table
				queryable = queryable.Include(x => x.Pessoa).ThenInclude(x => x.Genero)
									 .Include(x => x.Pessoa).ThenInclude(x => x.Titulo)
									 .Include(x => x.TipoEntidade);

				if (string.IsNullOrEmpty(codigoTipoEntidade))
					return queryable;

				queryable = queryable.Where(x => x.TipoEntidade.Codigo == codigoTipoEntidade);

				return queryable;
			});

			return new Response
			{
				Data = dbData.Data,
				Pagination = dbData.Pageable,
				Message = "Listed"
			};
		}

		// GET: api/Entidade/5:12837918237
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

		// POST: api/Entidade
		[HttpPost]
		public async Task<Response> Post([FromBody] EntidadeDto model)
		{
            if (model == null)
                throw new AppException("Objecto inválido!", true);

            await service.Save(model);
            return new Response { Message = "Created" };
		}

		// PUT: api/Entidade/5:12837918237
		[HttpPut("{uid}")]
		public async Task<Response> Put(string uid, [FromBody] EntidadeDto model)
		{
			try
			{
				if (model == null)
					throw new AppException("Objecto inválido!", true);

				await service.Update(uid, model);

				return new Response { Message = "Updated" };
			}
			catch (AppException ex)
			{
				return new Response
				{
					Errors = ex.Errors
				};
			}
		}

		// DELETE: api/Entidade/5:12837918237
		[HttpDelete("{uid}")]
		public async Task<Response> Delete(string uid)
		{
            await service.Remove(uid);
            return new Response { Message = "Deleted" };
		}
	}
}
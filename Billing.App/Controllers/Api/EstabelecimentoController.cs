using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billing.App.Routes;
using Billing.Service.Dto;
using Billing.App.Models;
using Billing.Service.Services.Interfaces;
using Billing.Service.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Billing.App.Extensions;
using System.Linq;
using Billing.Service.Pageable;

namespace Billing.App.Controllers.Api
{
	[Route(ApiRoutes.Base)]
	[ApiController]
	// [Authorize]
	public class EstabelecimentoController : ControllerBase
	{
		private IEstabelecimentoService service = null;
		private IFuncionarioService funcionarioService = null;

		public EstabelecimentoController(IEstabelecimentoService service, IFuncionarioService funcionarioService)
		{
			this.service = service;
			this.funcionarioService = funcionarioService;
		}

		// GET: api/Estabelecimento
		[HttpGet]
		public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
		{
			var dbData = await service.FindAll(pageableQuery,
				queryable => queryable.Include(x => x.Gerente.Usuario.Pessoa));

			return new Response
			{
				Data = dbData.Data,
				Pagination = dbData.Pageable,
				Message = "Listed"
			};
		}

		// GET: api/Estabelecimento/5:12837918237
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

		// GET: api/Estabelecimento
		[HttpGet("info/user")]
		public async Task<Response> GetUserEstablishment()
		{
			var userId = long.Parse(HttpContext.GetUserId());

			var dbData = await service.Find(predicate => predicate.Funcionarios.Any(x => x.UsuarioId == userId),
				queryable => queryable.Include(x => x.Gerente.Usuario.Pessoa)
										.Include(x => x.Endereco.Pais));

			return new Response
			{
				Data = dbData
			};
		}

		// POST: api/Estabelecimento
		[HttpPost]
		public async Task<Response> Post([FromBody] EstabelecimentoDto model)
		{
			if (model == null)
				throw new AppException("Objecto inválido!", true);

			await service.Save(model);
			return new Response { Message = "Created" };
		}

		// PUT: api/Estabelecimento/5:12837918237
		[HttpPut("{uid}")]
		public async Task<Response> Put(string uid, [FromBody] EstabelecimentoDto model)
		{
            if (model == null)
                throw new AppException("Objecto inválido!", true);

            await service.Update(uid, model);
            return new Response { Message = "Updated" };
		}

		// PUT: api/Estabelecimento/update-manager/5:12837918237
		[HttpPut("update-manager/{id}")]
		public async Task<Response> PutGerente(long id, [FromBody] EstabelecimentoDto model)
		{
            if (model == null)
                throw new AppException("Objecto inválido!", true);

            await service.UpdateGerente(id, model);
            return new Response { Message = "Updated" };
		}

		// PUT: api/Estabelecimento/update-regime/5:12837918237
		[HttpPut("update-manager/{id}")]
		public async Task<Response> PutRegime(long id, [FromBody] EstabelecimentoDto model)
		{
            if (model == null)
                throw new AppException("Objecto inválido!", true);

            await service.UpdateRegime(id, model);
            return new Response { Message = "Updated" };
		}

		// DELETE: api/Estabelecimento/5:12837918237
		[HttpDelete("{uid}")]
		public async Task<Response> Delete(string uid)
		{
            await service.Remove(uid);
            return new Response { Message = "Deleted" };
		}
	}
}
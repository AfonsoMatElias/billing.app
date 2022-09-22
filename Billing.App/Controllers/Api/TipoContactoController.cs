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
    public class TipoContactoController : ControllerBase
    {
        private ITipoContactoService service = null;

        public TipoContactoController(ITipoContactoService service)
        {
            this.service = service;
        }

        // GET: api/TipoContacto
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

        // GET: api/TipoContacto/5:12837918237
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

        // POST: api/TipoContacto
        [HttpPost]
        public async Task<Response> Post([FromBody] TipoContactoDto model)
        {
            if (model == null)
                throw new AppException("Objecto inválido!", true);

            await service.Save(model);
            return new Response { Message = "Created" };
        }

        // PUT: api/TipoContacto/5:12837918237
        [HttpPut("{uid}")]
        public async Task<Response> Put(string uid, [FromBody] TipoContactoDto model)
        {
            if (model == null)
                throw new AppException("Objecto inválido!", true);

            await service.Update(uid, model);
            return new Response { Message = "Updated" };
        }

        // DELETE: api/TipoContacto/5:12837918237
        [HttpDelete("{uid}")]
        public async Task<Response> Delete(string uid)
        {
            await service.Remove(uid);
            return new Response { Message = "Deleted" };
        }
    }
}
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
    public class RegimeController : ControllerBase
    {
        private IRegimeService service = null;

        public RegimeController(IRegimeService service)
        {
            this.service = service;
        }

        // GET: api/Regime
        [HttpGet]
        public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
        {
            try
            {
                var dbData = await service.FindAll(Pagination.Of(pageableQuery.Page, pageableQuery.Size));

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

        // GET: api/Regime/5:12837918237
        [HttpGet("{uid}")]
        public async Task<Response> Get(string uid)
        {
            try
            {
                var dbData = await service.FindById(uid);

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

        // POST: api/Regime
        [HttpPost]
        public async Task<Response> Post([FromBody] RegimeDto model)
        {
            try
            {
                if (model == null)
                    throw new AppException("Objecto inválido!", true);

                await service.Save(model);

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

        // PUT: api/Regime/5:12837918237
        [HttpPut("{uid}")]
        public async Task<Response> Put(string uid, [FromBody] RegimeDto model)
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

        // DELETE: api/Regime/5:12837918237
        [HttpDelete("{uid}")]
        public async Task<Response> Delete(string uid)
        {
            try
            {
                await service.Remove(uid);
            
                return new Response { Message = "Deleted" };
            }
            catch (AppException ex)
            {
                return new Response
                {
                    Errors = ex.Errors
                };
            }
        }
    }
}
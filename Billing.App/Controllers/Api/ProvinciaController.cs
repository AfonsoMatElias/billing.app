using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billing.App.Routes;
using Billing.Service.Dto;
using Billing.App.Models;
using Billing.Service.Services.Interfaces;
using Billing.Service.Responses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Billing.Service.Extensions;
using Billing.Service.Pageable;

namespace Billing.App.Controllers.Api
{
    [Route(ApiRoutes.Base)]
    [ApiController]
    // [Authorize]
    public class ProvinciaController : ControllerBase
    {
        private IProvinciaService service = null;
        private IWebHostEnvironment env;

        public ProvinciaController(IProvinciaService service, IWebHostEnvironment env)
        {
            this.service = service;
            this.env = env;
        }

        // GET: api/Provincia
        [HttpGet("all-in")]
        public async Task<Response> Get()
        {
            try
            {
                var dbData = await service.FindAll(queryable => 
                    queryable.Include(x => x.Municipios)
                             .ThenInclude(x => x.Comunas));

                return new Response
                {
                    Data = dbData
                };
            }
            catch (AppException ex)
            {
                return new Response
                {
                    Errors = ex.Errors,
                    Message = "Listed"
                };
            }
        }

        // GET: api/Provincia
        [HttpGet]
        public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
        {
            try
            {
                var _result = await service.Context().ExecuteAsync("SELECT * FROM Provincia");

                var dbData = await service.FindAll(Pagination.Of(pageableQuery.Page, pageableQuery.Size));

                return new Response
                {
                    Data = dbData.Data,
                    Pagination = dbData.Pageable
                };
            }
            catch (AppException ex)
            {
                return new Response
                {
                    Errors = ex.Errors,
                    Message = "Listed"
                };
            }
        }

        // GET: api/Provincia/5:12837918237
        [HttpGet("{uid}")]
        public async Task<Response> Get(string uid)
        {
            try
            {
                var dbData = await service.FindById(uid, query => {
                    return query.Include(x => x.Municipios).ThenInclude(x => x.Comunas);
                });

                return new Response
                {
                    Data = dbData,
                    Message = "Response Object"
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

        // POST: api/Provincia
        [HttpPost]
        public async Task<Response> Post([FromBody] ProvinciaDto model)
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

        // PUT: api/Provincia/5:12837918237
        [HttpPut("{uid}")]
        public async Task<Response> Put(string uid, [FromBody] ProvinciaDto model)
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

        // DELETE: api/Provincia/5:12837918237
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

        [HttpGet("seed-table")]
        public async Task<Response> LoadTableData()
        {
            // Building the path
            var fileData = $"{ env.ContentRootPath }/TableSeeds/json/provincias-comunas.json";

            // Checking if the file exists
            if (!System.IO.File.Exists(fileData))
                return new Response
                {
                    Message = "Seed file does not exists"
                };

            // Loading the data
            var dataString = System.IO.File.ReadAllText(fileData);

            // Converting the data
            var dataObjects = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.List<ProvinciaDto>>(dataString);

            // Loading the data count and creating the check property
            var hasData = await service.Count() > 0;

            // Checking if has data
            if (hasData)
                return new Response
                {
                    Message = "Table Already Seeded"
                };

            // Adding the data
            dataObjects.ForEach(async item =>
            {
                await service.Save(item, false);
            });

            // Saving them in the database
            await service.Commit();

            return new Response
            {
                Message = "Table Seeded"
            };

        }

    }
}
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

namespace Billing.App.Controllers.Api
{
    [Route(ApiRoutes.Base)]
    [ApiController]
    // [Authorize]
    public class ProdutoController : ControllerBase
    {
        private FileHandler fileHandler = null;
        private IProdutoService service = null;
        private IFuncionarioService funcionarioService = null;

        public ProdutoController(IProdutoService service, IFuncionarioService funcionarioService, FileHandler fileHandler)
        {
            this.service = service;
            this.funcionarioService = funcionarioService;
            this.fileHandler = fileHandler;
        }

        // GET: api/Produto
        [HttpGet]
        public async Task<Response> Get([FromQuery] PageableQueryParam pageableQuery)
        {
            try
            {
                var dbData = await service.FindAll(Pagination.Of(pageableQuery.Page, pageableQuery.Size),
                    queryable => queryable.Include(x => x.ProdutoImagens)
                                          .Include(x => x.SubCategoria));

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

        // GET: api/Produto/WithStock
        [HttpGet("WithStock")]
        public async Task<Response> GetWithStock([FromQuery] PageableQueryParam pageableQuery)
        {
            try
            {
                var dbData = await service.FindAll(Pagination.Of(pageableQuery.Page, pageableQuery.Size),
                    queryable => queryable.Include(x => x.ProdutoImagens)
                                          .Include(x => x.Compras.Where(y => y.IsActiva)));

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

        // POST: api/Produt
        [HttpPost]
        public async Task<Response> Post([FromForm] Attachments model)
        {
            try
            {
                if (model == null)
                    throw new AppException("Objecto inválido!", true);

                var builtModel = model.Build<ProdutoDto>();
                var images = new List<ProdutoImagemDto>();

                // Building the image items
                var files = model.Files.ToList()
                    .Select(item =>
                    {
                        // Building the file name
                        var fileName = $"{ Guid.NewGuid().ToString("N") }.{ item.ToExtension() }";

                        images.Add(new ProdutoImagemDto
                        {
                            ImageUrl = $"/download/product/{fileName}",
                        });

                        return new
                        {
                            fileData = item,
                            fileName = fileName
                        };
                    }).ToList();

                builtModel.ProdutoImagens = images;

                if (builtModel.Compras.Any())
                {
                    var compra = builtModel.Compras.FirstOrDefault();

                    var userId = long.Parse(HttpContext.GetUserId());
                    var funcionarioDto = await funcionarioService.Find(item => item.UsuarioId == userId);

                    if (funcionarioDto == null)
                        throw new AppException("Não tem permissão de criar um `Produto` com sua respectiva `Compra`", true);

                    compra.EstabelecimentoId = funcionarioDto.EstabelecimentoId;
                    compra.IsActiva = true;
                }

                await service.Save(builtModel)
                    .ContinueWith(async then =>
                    {
                        foreach (var item in files)
                            await fileHandler.Folder("product")
                                .SaveAsync(item.fileData, item.fileName);
                    });

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
        public async Task<Response> Put(string uid, [FromBody] ProdutoDto model)
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

        // DELETE: api/Produto/5:12837918237
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
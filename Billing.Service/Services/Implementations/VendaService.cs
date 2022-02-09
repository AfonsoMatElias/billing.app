using System;
using System.Linq;
using Billing.Shared;
using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Shared.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using AutoMapper;
using Billing.Service.Pageable;

namespace Billing.Service.Services.Implementations
{
    public class VendaService : BaseService<Venda>, IVendaService
    {
        public VendaService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<VendaDto> Find(Expression<Func<Venda, bool>> predicate, Func<IQueryable<Venda>, IQueryable<Venda>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<VendaDto>(dbModel);
        }

        public async Task<List<VendaDto>> FindAll(Func<IQueryable<Venda>, IQueryable<Venda>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<VendaDto>>(dbModels);
        }

        public async Task<Pagination<VendaDto>> FindAll(PageRange range, Func<IQueryable<Venda>, IQueryable<Venda>> queryable = null)
        {
            if (range == null)
                return new Pagination<VendaDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<VendaDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<VendaDto>>(pagination.Data)
            };
        }

        public async Task<VendaDto> FindById(string uid, Func<IQueryable<Venda>, IQueryable<Venda>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!");

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

            // Mapping and returning the values
            return mapper.Map<VendaDto>(dbModel);
        }

        public async Task Save(VendaDto model, bool isCommit = true)
        {

            if (model.Factura == null)
                throw new AppException($"Modelo inválido, falta de factura.", true);

            var tipoVenda = await mContext.TipoVenda.FirstOrDefaultAsync(x => x.Codigo == model.CodigoTipoVenda);
            var tipoFactura = await mContext.TipoFactura.FirstOrDefaultAsync(x => x.Codigo == model.Factura.CodigoTipoFactura);

            if (tipoVenda == null)
                throw new AppException($"Codigo de Tipo de Venda Inválido.", true);

            if (tipoFactura == null)
                throw new AppException($"Codigo de Tipo de Factura Inválido.", true);

            var dbModel = mapper.Map<Venda>(model);

            foreach (var item in dbModel.VendaItens)
            {
                var lastCompra = await mContext.Compra
                                               .Include(x => x.Produto)
                                               .FirstOrDefaultAsync(x => x.ProdutoId == item.ProdutoId && x.IsActiva);

                var stock = lastCompra.Quantidade;

                if ((stock - item.Quantidade) < 0)
                    throw new AppException($"Produto `{lastCompra.Produto.Nome}` tem o stock insuficiente para reduzir {item.Quantidade} itens", true);

                lastCompra.Quantidade -= item.Quantidade;
            }

            var uIndentifier = Guid.NewGuid().ToString().Split("-").First();

            // Generating the Selling Reference
            dbModel.Referencia = $"Ref:{uIndentifier}-{ DateTime.Now.ToString("yyMMdd") }";

            // Adding the Factura
            dbModel.Factura = new Factura
            {
                Referencia = dbModel.Referencia,
                TipoFacturaId = tipoFactura.Id
            };

            dbModel.TipoVendaId = tipoVenda.Id;

            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, VendaDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<Venda>(model), new[] {
                "id"
            });

            dbSet.Update(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Remove(string uid, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            dbModel.Visibility = false;

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task<long> Count() => await dbSet.LongCountAsync();
    }
}
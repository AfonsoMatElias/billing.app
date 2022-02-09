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
    public class CompraService : BaseService<Compra>, ICompraService
    {
        public CompraService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<CompraDto> Find(Expression<Func<Compra, bool>> predicate, Func<IQueryable<Compra>, IQueryable<Compra>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<CompraDto>(dbModel);
        }

        public async Task<List<CompraDto>> FindAll(Func<IQueryable<Compra>, IQueryable<Compra>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<CompraDto>>(dbModels);
        }

        public async Task<Pagination<CompraDto>> FindAll(PageRange range, Func<IQueryable<Compra>, IQueryable<Compra>> queryable = null)
        {
            if (range == null)
                return new Pagination<CompraDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<CompraDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<CompraDto>>(pagination.Data)
            };
        }

        public async Task<CompraDto> FindById(string uid, Func<IQueryable<Compra>, IQueryable<Compra>> queryable = null)
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
            return mapper.Map<CompraDto>(dbModel);
        }

        public async Task Save(CompraDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<Compra>(model);

            var lastCompra = await dbSet.FirstOrDefaultAsync(x => x.ProdutoId == model.ProdutoId && x.IsActiva);

            if (lastCompra == null)
                return;

            var product = await mContext.Produto.FirstOrDefaultAsync(x => x.Id == model.ProdutoId);

            // The last compra is not active anymore
            lastCompra.IsActiva = false;

            // If there is any Quantidade at last compra, add it to the new one
            if (lastCompra.Quantidade > 0)
                dbModel.Quantidade += lastCompra.Quantidade;

            // Updating the PrecoUnitario field 
            product.PrecoUnitario = lastCompra.PrecoUnitarioVenda;

            dbModel.IsActiva = true;

            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task SaveAll(CompraDto[] models)
        {
            foreach (var model in models)
            {
                var dbModel = mapper.Map<Compra>(model);

                var lastCompra = await dbSet.FirstOrDefaultAsync(x => x.ProdutoId == model.ProdutoId && x.IsActiva);

                if (lastCompra != null) {
                    var product = await mContext.Produto.FirstOrDefaultAsync(x => x.Id == model.ProdutoId);

                    // The last compra is not active anymore
                    lastCompra.IsActiva = false;

                    dbModel.QuantidadeEntrada = dbModel.Quantidade;

                    // If there is any Quantidade at last compra, add it to the new one
                    if (lastCompra.Quantidade > 0)
                        dbModel.Quantidade += lastCompra.Quantidade;

                    // Updating the PrecoUnitario field 
                    product.PrecoUnitario = lastCompra.PrecoUnitarioVenda;
                }

                dbModel.IsActiva = true;

                // Adding the result to the local storage
                await dbSet.AddAsync(dbModel);
            }

            if (dbSet.Local.Any())
                await this.Commit();
        }

        public async Task Update(string uid, CompraDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<Compra>(model), new[] {
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
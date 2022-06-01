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
    public class TipoFacturaService : BaseService<TipoFactura>, ITipoFacturaService
    {
        public TipoFacturaService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<TipoFacturaDto> Find(Expression<Func<TipoFactura, bool>> predicate, Func<IQueryable<TipoFactura>, IQueryable<TipoFactura>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<TipoFacturaDto>(dbModel);
        }

        public async Task<List<TipoFacturaDto>> FindAll(Func<IQueryable<TipoFactura>, IQueryable<TipoFactura>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<TipoFacturaDto>>(dbModels);
        }

        public async Task<Pagination<TipoFacturaDto>> FindAll(PageRange range, Func<IQueryable<TipoFactura>, IQueryable<TipoFactura>> queryable = null)
        {
            if (range == null)
                return new Pagination<TipoFacturaDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<TipoFacturaDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<TipoFacturaDto>>(pagination.Data)
            };
        }

        public async Task<TipoFacturaDto> FindById(string uid, Func<IQueryable<TipoFactura>, IQueryable<TipoFactura>> queryable = null)
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
            return mapper.Map<TipoFacturaDto>(dbModel);
        }

        public async Task Save(TipoFacturaDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<TipoFactura>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, TipoFacturaDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<TipoFactura>(model), new[] {
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
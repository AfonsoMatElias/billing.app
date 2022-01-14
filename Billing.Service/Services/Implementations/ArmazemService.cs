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
    public class ArmazemService : BaseService<Armazem>, IArmazemService
    {
        public ArmazemService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<ArmazemDto> Find(Expression<Func<Armazem, bool>> predicate, Func<IQueryable<Armazem>, IQueryable<Armazem>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<ArmazemDto>(dbModel);
        }

        public async Task<List<ArmazemDto>> FindAll(Func<IQueryable<Armazem>, IQueryable<Armazem>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<ArmazemDto>>(dbModels);
        }

        public async Task<Pagination<ArmazemDto>> FindAll(PageRange range, Func<IQueryable<Armazem>, IQueryable<Armazem>> queryable = null)
        {
            if (range == null)
                return new Pagination<ArmazemDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<ArmazemDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<ArmazemDto>>(pagination.Data)
            };
        }

        public async Task<ArmazemDto> FindById(string uid, Func<IQueryable<Armazem>, IQueryable<Armazem>> queryable = null)
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
            return mapper.Map<ArmazemDto>(dbModel);
        }

        public async Task Save(ArmazemDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<Armazem>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, ArmazemDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<Armazem>(model), new[] {
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
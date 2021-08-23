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
    public class ComunaService : BaseService<Comuna>, IComunaService
    {
        public ComunaService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<ComunaDto> Find(Expression<Func<Comuna, bool>> predicate, Func<IQueryable<Comuna>, IQueryable<Comuna>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<ComunaDto>(dbModel);
        }

        public async Task<List<ComunaDto>> FindAll(Func<IQueryable<Comuna>, IQueryable<Comuna>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<ComunaDto>>(dbModels);
        }

        public async Task<Pagination<ComunaDto>> FindAll(PageRange range, Func<IQueryable<Comuna>, IQueryable<Comuna>> queryable = null)
        {
            if (range == null)
                return new Pagination<ComunaDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<ComunaDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<ComunaDto>>(pagination.Data)
            };
        }

        public async Task<ComunaDto> FindById(string uid, Func<IQueryable<Comuna>, IQueryable<Comuna>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!");

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

            // Mapping and returning the values
            return mapper.Map<ComunaDto>(dbModel);
        }

        public async Task Save(ComunaDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<Comuna>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, ComunaDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<Comuna>(model), new[] {
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
            if(_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            dbSet.Remove(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task<long> Count() => await dbSet.LongCountAsync();
    }
}
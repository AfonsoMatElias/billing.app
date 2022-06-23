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
    public class SeccaoService : BaseService<Seccao>, ISeccaoService
    {
        public SeccaoService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<SeccaoDto> Find(Expression<Func<Seccao, bool>> predicate, Func<IQueryable<Seccao>, IQueryable<Seccao>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<SeccaoDto>(dbModel);
        }

        public async Task<List<SeccaoDto>> FindAll(Func<IQueryable<Seccao>, IQueryable<Seccao>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<SeccaoDto>>(dbModels);
        }

        public async Task<Pagination<SeccaoDto>> FindAll(PageRange range, Func<IQueryable<Seccao>, IQueryable<Seccao>> queryable = null)
        {
            if (range == null)
                return new Pagination<SeccaoDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<SeccaoDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<SeccaoDto>>(pagination.Data)
            };
        }

        public async Task<SeccaoDto> FindById(string uid, Func<IQueryable<Seccao>, IQueryable<Seccao>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!", true);

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

            // Mapping and returning the values
            return mapper.Map<SeccaoDto>(dbModel);
        }

        public async Task Save(SeccaoDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<Seccao>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, SeccaoDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!", true);

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<Seccao>(model), new[] {
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
                throw new AppException("Identificador Inválido!", true);

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            dbModel.Visibility = false;

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task<long> Count() => await dbSet.LongCountAsync();
    }
}
using System;
using System.Linq;
using Billing.Shared;
using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
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
    public class TipoEntidadeService : BaseService<TipoEntidade>, ITipoEntidadeService
    {
        public TipoEntidadeService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<TipoEntidadeDto> Find(Expression<Func<TipoEntidade, bool>> predicate, Func<IQueryable<TipoEntidade>, IQueryable<TipoEntidade>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<TipoEntidadeDto>(dbModel);
        }

        public async Task<List<TipoEntidadeDto>> FindAll(Func<IQueryable<TipoEntidade>, IQueryable<TipoEntidade>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<TipoEntidadeDto>>(dbModels);
        }

        public async Task<Pagination<TipoEntidadeDto>> FindAll(PageRange range, Func<IQueryable<TipoEntidade>, IQueryable<TipoEntidade>> queryable = null)
        {
            if (range == null)
                return new Pagination<TipoEntidadeDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<TipoEntidadeDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<TipoEntidadeDto>>(pagination.Data)
            };
        }

        public async Task<TipoEntidadeDto> FindById(string uid, Func<IQueryable<TipoEntidade>, IQueryable<TipoEntidade>> queryable = null)
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
            return mapper.Map<TipoEntidadeDto>(dbModel);
        }

        public async Task Save(TipoEntidadeDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<TipoEntidade>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, TipoEntidadeDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!", true);

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<TipoEntidade>(model), new[] {
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
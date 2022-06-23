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
    public class SubCategoriaService : BaseService<SubCategoria>, ISubCategoriaService
    {
        public SubCategoriaService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<SubCategoriaDto> Find(Expression<Func<SubCategoria, bool>> predicate, Func<IQueryable<SubCategoria>, IQueryable<SubCategoria>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<SubCategoriaDto>(dbModel);
        }

        public async Task<List<SubCategoriaDto>> FindAll(Func<IQueryable<SubCategoria>, IQueryable<SubCategoria>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<SubCategoriaDto>>(dbModels);
        }

        public async Task<Pagination<SubCategoriaDto>> FindAll(PageRange range, Func<IQueryable<SubCategoria>, IQueryable<SubCategoria>> queryable = null)
        {
            if (range == null)
                return new Pagination<SubCategoriaDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<SubCategoriaDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<SubCategoriaDto>>(pagination.Data)
            };
        }

        public async Task<SubCategoriaDto> FindById(string uid, Func<IQueryable<SubCategoria>, IQueryable<SubCategoria>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!", true);

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

            // Mapping and returning the values
            return mapper.Map<SubCategoriaDto>(dbModel);
        }

        public async Task Save(SubCategoriaDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<SubCategoria>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, SubCategoriaDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!", true);

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<SubCategoria>(model), new[] {
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
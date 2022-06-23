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
    public class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<FuncionarioDto> Find(Expression<Func<Funcionario, bool>> predicate, Func<IQueryable<Funcionario>, IQueryable<Funcionario>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<FuncionarioDto>(dbModel);
        }

        public async Task<List<FuncionarioDto>> FindAll(Func<IQueryable<Funcionario>, IQueryable<Funcionario>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<FuncionarioDto>>(dbModels);
        }

        public async Task<Pagination<FuncionarioDto>> FindAll(PageRange range, Func<IQueryable<Funcionario>, IQueryable<Funcionario>> queryable = null)
        {
            if (range == null)
                return new Pagination<FuncionarioDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<FuncionarioDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<FuncionarioDto>>(pagination.Data)
            };
        }

        public async Task<FuncionarioDto> FindById(string uid, Func<IQueryable<Funcionario>, IQueryable<Funcionario>> queryable = null)
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
            return mapper.Map<FuncionarioDto>(dbModel);
        }

        public async Task Save(FuncionarioDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<Funcionario>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, FuncionarioDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!", true);

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<Funcionario>(model), new[] {
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
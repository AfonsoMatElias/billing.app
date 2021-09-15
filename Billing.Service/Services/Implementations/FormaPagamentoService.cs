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
    public class FormaPagamentoService : BaseService<FormaPagamento>, IFormaPagamentoService
    {
        public FormaPagamentoService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<FormaPagamentoDto> Find(Expression<Func<FormaPagamento, bool>> predicate, Func<IQueryable<FormaPagamento>, IQueryable<FormaPagamento>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<FormaPagamentoDto>(dbModel);
        }

        public async Task<List<FormaPagamentoDto>> FindAll(Func<IQueryable<FormaPagamento>, IQueryable<FormaPagamento>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<FormaPagamentoDto>>(dbModels);
        }

        public async Task<Pagination<FormaPagamentoDto>> FindAll(PageRange range, Func<IQueryable<FormaPagamento>, IQueryable<FormaPagamento>> queryable = null)
        {
            if (range == null)
                return new Pagination<FormaPagamentoDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<FormaPagamentoDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<FormaPagamentoDto>>(pagination.Data)
            };
        }

        public async Task<FormaPagamentoDto> FindById(string uid, Func<IQueryable<FormaPagamento>, IQueryable<FormaPagamento>> queryable = null)
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
            return mapper.Map<FormaPagamentoDto>(dbModel);
        }

        public async Task Save(FormaPagamentoDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<FormaPagamento>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, FormaPagamentoDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if (_uid == null)
                throw new AppException("Identificador Inválido!");

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!");

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<FormaPagamento>(model), new[] {
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

            dbSet.Remove(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task<long> Count() => await dbSet.LongCountAsync();
    }
}
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
    public class EstabelecimentoService : BaseService<Estabelecimento>, IEstabelecimentoService
    {
        public EstabelecimentoService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<EstabelecimentoDto> Find(Expression<Func<Estabelecimento, bool>> predicate, Func<IQueryable<Estabelecimento>, IQueryable<Estabelecimento>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<EstabelecimentoDto>(dbModel);
        }

        public async Task<List<EstabelecimentoDto>> FindAll(Func<IQueryable<Estabelecimento>, IQueryable<Estabelecimento>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();
                
            // Mapping and returning the values
            return mapper.Map<List<EstabelecimentoDto>>(dbModels);
        }

        public async Task<Pagination<EstabelecimentoDto>> FindAll(PageRange range, Func<IQueryable<Estabelecimento>, IQueryable<Estabelecimento>> queryable = null)
        {
            if (range == null)
                return new Pagination<EstabelecimentoDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<EstabelecimentoDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<EstabelecimentoDto>>(pagination.Data)
            };
        }

        public async Task<EstabelecimentoDto> FindById(string uid, Func<IQueryable<Estabelecimento>, IQueryable<Estabelecimento>> queryable = null)
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
            return mapper.Map<EstabelecimentoDto>(dbModel);
        }

        public async Task Save(EstabelecimentoDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<Estabelecimento>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, EstabelecimentoDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!", true);

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<Estabelecimento>(model), new[] {
                "id"
            });

            dbSet.Update(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task UpdateGerente(long id, EstabelecimentoDto model)
        {
            var dbModel = await this.dbSet.FindAsync(id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.GerenteId = model.GerenteId;
            dbSet.Update(dbModel);

            await this.Commit();
        }

        public async Task UpdateRegime(long id, EstabelecimentoDto model)
        {
            var dbModel = await this.dbSet.FindAsync(id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.RegimeId = model.RegimeId;
            dbSet.Update(dbModel);

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
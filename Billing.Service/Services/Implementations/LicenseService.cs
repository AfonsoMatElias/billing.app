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
    public class LicenseService : BaseService<License>, ILicenseService
    {
        public LicenseService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public async Task<LicenseDto> Find(Expression<Func<License, bool>> predicate, Func<IQueryable<License>, IQueryable<License>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

            // Mapping and returning the value
            return mapper.Map<LicenseDto>(dbModel);
        }

        public async Task<List<LicenseDto>> FindAll(Func<IQueryable<License>, IQueryable<License>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            var dbModels = await queryable(dbSet).ToListAsync();

            // Mapping and returning the values
            return mapper.Map<List<LicenseDto>>(dbModels);
        }

        public async Task<Pagination<LicenseDto>> FindAll(PageRange range, Func<IQueryable<License>, IQueryable<License>> queryable = null)
        {
            if (range == null)
                return new Pagination<LicenseDto>
                {
                    Data = await this.FindAll(queryable)
                };

            var pagination = await dbSet.ToPagedListAsync(range, queryable);

            return new Pagination<LicenseDto>
            {
                Pageable = pagination.Pageable,
                Data = mapper.Map<List<LicenseDto>>(pagination.Data)
            };
        }

        public async Task<LicenseDto> FindById(string uid, Func<IQueryable<License>, IQueryable<License>> queryable = null)
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;


            // Applying the queryable value and the predicate to the expression
            var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == long.Parse(uid));

            // Mapping and returning the values
            return mapper.Map<LicenseDto>(dbModel);
        }

        public async Task Save(LicenseDto model, bool isCommit = true)
        {
            var dbModel = mapper.Map<License>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task Update(string uid, LicenseDto model, bool isCommit = true)
        {
            var _uid = uid.FromUID();
            if(_uid == null)
                throw new AppException("Identificador Inválido!", true);

            var dbModel = await this.dbSet.FindAsync(_uid.Id);

            if (dbModel == null)
                throw new AppException("Registrado não encontrado!", true);

            // DB Model Update
            dbModel.UpdateFrom(mapper.Map<License>(model), new[] {
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

            dbSet.Remove(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }

        public async Task<long> Count() => await dbSet.LongCountAsync();
    }
}
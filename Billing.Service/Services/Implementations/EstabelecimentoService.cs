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
    public class EstabelecimentoService : BaseService<Estabelecimento, EstabelecimentoDto>, IEstabelecimentoService
    {
        public EstabelecimentoService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

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
    }
}
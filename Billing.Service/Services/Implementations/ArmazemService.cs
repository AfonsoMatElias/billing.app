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
    public class ArmazemService : BaseService<Armazem, ArmazemDto>, IArmazemService
    {
        public ArmazemService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public override async Task Save(ArmazemDto model, bool isCommit = true) 
        {
            var dbModel = mapper.Map<Armazem>(model);
            // Adding the result to the local storage
            await dbSet.AddAsync(dbModel);

            if (!isCommit)
                return;

            await this.Commit();
        }
    }
}
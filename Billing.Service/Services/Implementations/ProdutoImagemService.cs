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
    public class ProdutoImagemService : BaseService<ProdutoImagem, ProdutoImagemDto>, IProdutoImagemService
    {
        public ProdutoImagemService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

		public async Task SaveMany(ProdutoImagemDto[] models)
		{
			var dbModel = mapper.Map<ProdutoImagem[]>(models);
            // Adding the result to the local storage
            await dbSet.AddRangeAsync(dbModel);

            await this.Commit();
		}

		public async Task RemoveMany(long[] filesToRemove)
		{
			if (filesToRemove == null)
				return;

            var items = await dbSet.Where(x => filesToRemove.Contains(x.Id)).ToListAsync();
			dbSet.RemoveRange(items);

			await this.Commit();
		}
	}
}
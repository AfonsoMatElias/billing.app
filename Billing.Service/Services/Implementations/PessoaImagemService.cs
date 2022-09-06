using System;
using System.Linq;
using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using System.Threading.Tasks;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using AutoMapper;

namespace Billing.Service.Services.Implementations
{
	public class PessoaImagemService : BaseService<PessoaImagem, PessoaImagemDto>, IPessoaImagemService
	{
		public PessoaImagemService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

		public async Task RemoveMany(long[] filesToRemove)
		{
			if (filesToRemove == null)
				return;

            var items = dbSet.Where(x => filesToRemove.Contains(x.Id));
			dbSet.RemoveRange(items);

			await this.Commit();
		}
	}
}

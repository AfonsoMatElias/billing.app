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
	public class PessoaImagemService : BaseService<PessoaImagem>, IPessoaImagemService
	{
		public PessoaImagemService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

		public async Task<PessoaImagemDto> Find(Expression<Func<PessoaImagem, bool>> predicate, Func<IQueryable<PessoaImagem>, IQueryable<PessoaImagem>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			// Applying the queryable value and the predicate to the expression
			var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

			// Mapping and returning the value
			return mapper.Map<PessoaImagemDto>(dbModel);
		}

		public async Task<List<PessoaImagemDto>> FindAll(Func<IQueryable<PessoaImagem>, IQueryable<PessoaImagem>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			var dbModels = await queryable(dbSet).ToListAsync();

			// Mapping and returning the values
			return mapper.Map<List<PessoaImagemDto>>(dbModels);
		}

		public async Task<Pagination<PessoaImagemDto>> FindAll(PageRange range, Func<IQueryable<PessoaImagem>, IQueryable<PessoaImagem>> queryable = null)
		{
			if (range == null)
				return new Pagination<PessoaImagemDto>
				{
					Data = await this.FindAll(queryable)
				};

			var pagination = await dbSet.ToPagedListAsync(range, queryable);

			return new Pagination<PessoaImagemDto>
			{
				Pageable = pagination.Pageable,
				Data = mapper.Map<List<PessoaImagemDto>>(pagination.Data)
			};
		}

		public async Task<PessoaImagemDto> FindById(string uid, Func<IQueryable<PessoaImagem>, IQueryable<PessoaImagem>> queryable = null)
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
			return mapper.Map<PessoaImagemDto>(dbModel);
		}

		public async Task Save(PessoaImagemDto model, bool isCommit = true)
		{
			var dbModel = mapper.Map<PessoaImagem>(model);
			// Adding the result to the local storage
			await dbSet.AddAsync(dbModel);

			if (!isCommit)
				return;

			await this.Commit();
		}

		public async Task Update(string uid, PessoaImagemDto model, bool isCommit = true)
		{
			var _uid = uid.FromUID();
			if (_uid == null)
				throw new AppException("Identificador Inválido!", true);

			var dbModel = await this.dbSet.FindAsync(_uid.Id);

			if (dbModel == null)
				throw new AppException("Registrado não encontrado!", true);

			// DB Model Update
			dbModel.UpdateFrom(mapper.Map<PessoaImagem>(model), new[] {
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
				throw new AppException("Registrado não encontrado!", true);

			dbSet.Remove(dbModel);

			if (!isCommit)
				return;

			await this.Commit();
		}

		public async Task<long> Count() => await dbSet.LongCountAsync();

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

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
using System.Net;

namespace Billing.Service.Services.Implementations
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        public UsuarioService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

		public virtual async Task<UsuarioDto> Find(Expression<Func<Usuario, bool>> predicate, Func<IQueryable<Usuario>, IQueryable<Usuario>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			// Applying the queryable value and the predicate to the expression
			var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

			// Mapping and returning the value
			return mapper.Map<UsuarioDto>(dbModel);
		}

		public virtual async Task<List<UsuarioDto>> FindAll(Func<IQueryable<Usuario>, IQueryable<Usuario>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			var dbModels = await queryable(dbSet).Where(x => (bool)x.Visibility)
				.OrderByDescending(x => x.CreatedAt)
				.ToListAsync();

			// Mapping and returning the values
			return mapper.Map<List<UsuarioDto>>(dbModels);
		}

		public virtual async Task<Pagination<UsuarioDto>> FindAll(PageRange range, Func<IQueryable<Usuario>, IQueryable<Usuario>> queryable = null)
		{
			if (range == null)
				return new Pagination<UsuarioDto>
				{
					Data = await this.FindAll(queryable)
				};

			var pagination = await dbSet.Where(x => (bool)x.Visibility)
				.OrderByDescending(x => x.CreatedAt)
				.ToPagedListAsync(range, queryable);

			return new Pagination<UsuarioDto>
			{
				Pageable = pagination.Pageable,
				Data = mapper.Map<List<UsuarioDto>>(pagination.Data)
			};
		}

		public virtual async Task<UsuarioDto> FindById(long id, Func<IQueryable<Usuario>, IQueryable<Usuario>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			// Applying the queryable value and the predicate to the expression
			var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == id);

			// Mapping and returning the values
			return mapper.Map<UsuarioDto>(dbModel);
		}
		public virtual async Task<UsuarioDto> FindById(string uid, Func<IQueryable<Usuario>, IQueryable<Usuario>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			var _uid = uid.FromUID();
			if (_uid == null)
				throw new AppException("Identificador Inválido!", true);

			// Applying the queryable value and the predicate to the expression
			var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item =>
				item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

			// Mapping and returning the values
			return mapper.Map<UsuarioDto>(dbModel);
		}


		public virtual async Task Save(UsuarioDto model, bool autoCommit = true)
		{
			var dbModel = mapper.Map<Usuario>(model);
			// Adding the result to the local storage
			await dbSet.AddAsync(dbModel);

			if (!autoCommit)
				return;

			await Commit();
		}

		public virtual async Task Update(long id, UsuarioDto model, bool autoCommit = true)
		{
			var dbModel = await dbSet.FindAsync(id);

			if (dbModel == null)
				throw new AppException("Registrado não encontrado!", true, (int)HttpStatusCode.NotFound);

			var fieldsToIgnore = typeof(Models.Base.Properties).GetProperties().Select(x => x.Name).ToHashSet();

			// Db Model Update
			dbModel.UpdateFrom(mapper.Map<Usuario>(model), fieldsToIgnore);

			// Setting the new date
			dbModel.UpdatedAt = DateTime.Now;

			// Updating the local db
			dbSet.Update(dbModel);

			if (!autoCommit)
				return;

			// Commting all the changes
			await Commit();
		}
		public virtual async Task Update(string uid, UsuarioDto model, bool isCommit = true)
		{
			var _uid = uid.FromUID();
			if (_uid == null)
				throw new AppException("Identificador Inválido!", true);

			var dbModel = await this.dbSet.FirstOrDefaultAsync(item =>
				item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

			if (dbModel == null)
				throw new AppException("Registrado não encontrado!", true);

			// DB Model Update
			var fieldsToIgnore = typeof(Models.Base.Properties).GetProperties().Select(x => x.Name).ToHashSet();

			// Db Model Update
			dbModel.UpdateFrom(mapper.Map<Usuario>(model), fieldsToIgnore);

			dbSet.Update(dbModel);

			if (!isCommit)
				return;

			await this.Commit();
		}

		public virtual async Task Remove(long id, bool autoCommit = true)
		{
			var dbModel = await dbSet.FindAsync(id);

			if (dbModel == null)
				throw new AppException("Registrado não encontrado!", true, (int)HttpStatusCode.NotFound);

			dbModel.Visibility = true;

			if (!autoCommit)
				return;

			await Commit();
		}
		public virtual async Task Remove(string uid, bool isCommit = true)
		{
			var _uid = uid.FromUID();
			if (_uid == null)
				throw new AppException("Identificador Inválido!", true);

			var dbModel = await this.dbSet.FirstOrDefaultAsync(item =>
				item.Id == _uid.Id && item.CreatedAt == _uid.CreatedAt);

			if (dbModel == null)
				throw new AppException("Registrado não encontrado!", true);

			dbModel.Visibility = false;

			if (!isCommit)
				return;

			await this.Commit();
		}

		public virtual async Task<long> Count() => await dbSet.LongCountAsync();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Billing.Service.Data;
using Billing.Service.Models.Base;
using Billing.Service.Pageable;
using Billing.Shared;
using Microsoft.EntityFrameworkCore;

namespace Billing.Service.Services.Implementations.Base
{
	///<summary>
	/// A base class shared by all the app implementations
	///</summary>    
	public class BaseService<TModel> where TModel : class
	{
		///<summary>
		/// Default Controller
		///</summary>    
		public BaseService(IMapper mapper, DataContext mContext)
		{
			this.mapper = mapper;
			this.mContext = mContext;
			// Setting the default db set of the service
			this.dbSet = mContext.Set<TModel>();
		}

		protected IMapper mapper;
		protected DataContext mContext;
		protected DbSet<TModel> dbSet;

		///<summary>
		/// Commits/Saves changes made to the database catching all the errors ocurred in the process
		///</summary>    
		public async Task<bool> Commit()
		{
			var isAnyAffectedRows = false;

			Action<Exception> RaiseException = (Exception ex) =>
			{
				throw new AppException(ex.InnerException?.Message ?? ex.Message, false, (int)HttpStatusCode.InternalServerError);
			};

			try
			{
				isAnyAffectedRows = await mContext.SaveChangesAsync() > 0 ? true : false;

				if (!isAnyAffectedRows)
					System.Diagnostics.Debugger.Log(
						(int)Microsoft.Extensions.Logging.LogLevel.Warning, "Server: ", "No rows affected"
					);
			}
			catch (DbUpdateConcurrencyException ex)
			{
				RaiseException(ex);
			}
			catch (DbUpdateException ex)
			{
				RaiseException(ex);
			}
			// Catch the base Exceptions
			catch (Exception ex)
			{
				RaiseException(ex);
			}

			return isAnyAffectedRows;
		}
	}

	///<summary>
	/// A base class shared by all the app implementations
	///</summary>    
	public class BaseService<TModel, TDtoModel> : BaseService<TModel>
		where TModel : Models.Base.Properties, new()
		where TDtoModel : Dto.Base.Properties, new()
	{
		///<summary>
		/// Default Controller
		///</summary>    
		public BaseService(IMapper mapper, DataContext mContext) : base(mapper, mContext) { }

		public virtual async Task<TDtoModel> Find(Expression<Func<TModel, bool>> predicate, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			// Applying the queryable value and the predicate to the expression
			var dbModel = await queryable(dbSet).FirstOrDefaultAsync(predicate);

			// Mapping and returning the value
			return mapper.Map<TDtoModel>(dbModel);
		}

		public virtual async Task<List<TDtoModel>> FindAll(Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			var dbModels = await queryable(dbSet).Where(x => (bool)x.Visibility)
				.OrderByDescending(x => x.CreatedAt)
				.ToListAsync();

			// Mapping and returning the values
			return mapper.Map<List<TDtoModel>>(dbModels);
		}

		public virtual async Task<Pagination<TDtoModel>> FindAll(PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
		{
			if (range == null)
				return new Pagination<TDtoModel>
				{
					Data = await this.FindAll(queryable)
				};

			var pagination = await dbSet.Where(x => (bool)x.Visibility)
				.OrderByDescending(x => x.CreatedAt)
				.ToPagedListAsync(range, queryable);

			return new Pagination<TDtoModel>
			{
				Pageable = pagination.Pageable,
				Data = mapper.Map<List<TDtoModel>>(pagination.Data)
			};
		}

		public virtual async Task<TDtoModel> FindById(long id, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			// Applying the queryable value and the predicate to the expression
			var dbModel = await queryable(dbSet).FirstOrDefaultAsync(item => item.Id == id);

			// Mapping and returning the values
			return mapper.Map<TDtoModel>(dbModel);
		}

		public virtual async Task<TDtoModel> FindById(string uid, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
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
			return mapper.Map<TDtoModel>(dbModel);
		}

		public virtual async Task Save(TDtoModel model, bool autoCommit = true)
		{
			var dbModel = mapper.Map<TModel>(model);
			// Adding the result to the local storage
			await dbSet.AddAsync(dbModel);

			if (!autoCommit)
				return;

			await Commit();
		}

		public virtual async Task Update(long id, TDtoModel model, bool autoCommit = true)
		{
			var dbModel = await dbSet.FindAsync(id);

			if (dbModel == null)
				throw new AppException("Registrado não encontrado!", true, (int)HttpStatusCode.NotFound);

			var fieldsToIgnore = typeof(Models.Base.Properties).GetProperties().Select(x => x.Name).ToHashSet();

			// Db Model Update
			dbModel.UpdateFrom(mapper.Map<TModel>(model), fieldsToIgnore);

			// Setting the new date
			dbModel.UpdatedAt = DateTime.Now;

			// Updating the local db
			dbSet.Update(dbModel);

			if (!autoCommit)
				return;

			// Commting all the changes
			await Commit();
		}

		public virtual async Task Update(string uid, TDtoModel model, bool isCommit = true)
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
			dbModel.UpdateFrom(mapper.Map<TModel>(model), fieldsToIgnore);

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
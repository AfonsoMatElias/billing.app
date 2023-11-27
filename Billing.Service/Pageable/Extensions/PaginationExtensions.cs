using System;
using System.Linq;
using System.Threading.Tasks;
using Billing.Service.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Billing.Service.Pageable
{
	public static class PaginationExtensions
	{

		private static Pagination<TModel> ApplyPagedList<TModel>(IQueryable<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
			where TModel : class
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			// Querying the elements
			var query = queryable(dbSet);

			// Applying the pagination split
			var paged = query.Skip((((int)range.Size * ((int)range.Page)) - (int)range.Size))
					.Take((int)range.Size).ToList();

			// Building the pagination
			return new Pagination<TModel>
			{
				Data = paged,
				Pageable = Pagination.Calculate(range, query.LongCount(), paged.LongCount())
			};
		}

		private static async Task<Pagination<TModel>> ApplyPagedListAsync<TModel>(IQueryable<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
			where TModel : class
		{
			// If the queryable argument is null define the default one
			if (queryable == null)
				queryable = func => func;

			// Querying the elements
			var query = queryable(dbSet);

			// Applying the pagination split
			var paged = await query.Skip((((int)range.Size * ((int)range.Page)) - (int)range.Size))
					.Take((int)range.Size).ToListAsync();

			// Building the pagination
			return new Pagination<TModel>
			{
				Data = paged,
				Pageable = Pagination.Calculate(range, query.LongCount(), paged.LongCount())
			};
		}

		/// <summary>
		/// Apply pagination to IQueryable 
		/// </summary>
		/// <param name="dbSet">The DbSet having the data</param>
		/// <param name="range">The pagination range</param>
		/// <param name="queryable">The queryable function for filtering</param>
		/// <typeparam name="TModel">Model Type</typeparam>
		/// <returns>Pagination Object</returns>
		public static Pagination<TModel> ToPagedList<TModel>(this IQueryable<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
			where TModel : class
		{
			return ApplyPagedList(dbSet, range, queryable);
		}

		/// <summary>
		/// Apply pagination to DbSet 
		/// </summary>
		/// <param name="dbSet">The DbSet having the data</param>
		/// <param name="range">The pagination range</param>
		/// <param name="queryable">The queryable function for filtering</param>
		/// <typeparam name="TModel">Model Type</typeparam>
		/// <returns>Pagination Object</returns>
		public static Pagination<TModel> ToPagedList<TModel>(this DbSet<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
			where TModel : class
		{
			return ApplyPagedList(dbSet, range, queryable);
		}


		/// <summary>
		/// Apply pagination to IQueryable asynchronously
		/// </summary>
		/// <param name="dbSet">The DbSet having the data</param>
		/// <param name="range">The pagination range</param>
		/// <param name="queryable">The queryable function for filtering</param>
		/// <typeparam name="TModel">Model Type</typeparam>
		/// <returns>Pagination Object</returns>
		public static async Task<Pagination<TModel>> ToPagedListAsync<TModel>(this IQueryable<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
			where TModel : class
		{
			return await ApplyPagedListAsync(dbSet, range, queryable);
		}

		/// <summary>
		/// Apply pagination to DbSet asynchronously
		/// </summary>
		/// <param name="dbSet">The DbSet having the data</param>
		/// <param name="range">The pagination range</param>
		/// <param name="queryable">The queryable function for filtering</param>
		/// <typeparam name="TModel">Model Type</typeparam>
		/// <returns>Pagination Object</returns>
		public static async Task<Pagination<TModel>> ToPagedListAsync<TModel>(this DbSet<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
			where TModel : class
		{
			return await ApplyPagedListAsync(dbSet, range, queryable);
		}
	}
}
using System;
using System.Linq;
using System.Threading.Tasks;
using Billing.Service.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Billing.Service.Pageable
{
    public static class PaginationExtensions
    {
        public static Pagination<TModel> ToPagedList<TModel>(this DbSet<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
            where TModel : class
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Querying the elements
            var query = queryable(dbSet).ToList();
            
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
        
        public static async Task<Pagination<TModel>> ToPagedListAsync<TModel>(this DbSet<TModel> dbSet, PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null)
            where TModel : class
        {
            // If the queryable argument is null define the default one
            if (queryable == null)
                queryable = func => func;

            // Querying the elements
            var query = await queryable(dbSet).ToListAsync();
            
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
    }
}
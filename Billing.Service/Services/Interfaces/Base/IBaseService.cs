using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Billing.Service.Pageable;

namespace Billing.Service.Services.Interfaces.Base
{
    ///<summary>
    /// A base interface shared by all the app interfaces
    ///</summary>    
    public interface IBaseService<TModel, TDto>
        where TModel : class
        where TDto : class
    {
        ///<summary>
        /// Finds an element according to a predicate
        ///</summary>
        Task<TDto> Find(Expression<Func<TModel, bool>> predicate, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null);

        ///<summary>
        /// Finds all the elements according to a predicate
        ///</summary>
        Task<List<TDto>> FindAll(Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null);

        ///<summary>
        /// Finds all the elements according to a predicate
        ///</summary>
        Task<Pagination<TDto>> FindAll(PageRange range, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null);

        ///<summary>
        /// Finds the first element having the id value
        ///</summary>
        Task<TDto> FindById(string uid, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null);

        ///<summary>
        /// Saves a model to the database
        ///</summary>
        Task Save(TDto model, bool isCommit = true);

        ///<summary>
        /// Updates a model from the database
        ///</summary>
        Task Update(string uid, TDto model, bool isCommit = true);

        ///<summary>
        /// Removes a model from the database
        ///</summary>
        Task Remove(string uid, bool isCommit = true);

        ///<summary>
        /// Counts the number of elements in database
        ///</summary>
        Task<long> Count();

        ///<summary>
        /// Commits/Saves changes made to the database catching all the errors ocurred in the process
        ///</summary>    
        Task<bool> Commit();
    }

    ///<summary>
    /// A base interface shared by all the app interfaces with other response type
    ///</summary>    
    public interface IBaseService<TModel, TDtoRequest, TDtoResponse>
        where TModel : class
        where TDtoRequest : class
        where TDtoResponse : class
    {
        ///<summary>
        /// Finds an element according to a predicate
        ///</summary>
        Task<TDtoResponse> Find(Expression<Func<TModel, bool>> predicate, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null);

        ///<summary>
        /// Finds all the elements according to a predicate
        ///</summary>
        Task<List<TDtoResponse>> FindAll(Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null);

        ///<summary>
        /// Finds the first element having the id value
        ///</summary>
        Task<TDtoResponse> FindById(string uid, Func<IQueryable<TModel>, IQueryable<TModel>> queryable = null);

        ///<summary>
        /// Saves a model to the database
        ///</summary>
        Task Save(TDtoRequest model, bool isCommit = true);

        ///<summary>
        /// Updates a model from the database
        ///</summary>
        Task Update(string uid, TDtoRequest model, bool isCommit = true);

        ///<summary>
        /// Removes a model from the database
        ///</summary>
        Task Remove(string uid, bool isCommit = true);

        ///<summary>
        /// Counts the number of elements in database
        ///</summary>
        Task<long> Count();

        ///<summary>
        /// Commits/Saves changes made to the database catching all the errors ocurred in the process
        ///</summary>   
        Task<bool> Commit();
    }
}
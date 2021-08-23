using System.Threading.Tasks;
using AutoMapper;
using Billing.Service.Data;
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

            try
            {
                isAnyAffectedRows = await mContext.SaveChangesAsync() > 0 ? true : false;
                
                if (!isAnyAffectedRows)
                    throw new AppException("Erro ao salvar os dados", true);
            }
            // Catch the base Exceptions
            catch (DbUpdateException ex) 
            {
                throw new AppException(ex.InnerException?.Message ?? ex.Message);
            }

            return isAnyAffectedRows;
        }
    }
}
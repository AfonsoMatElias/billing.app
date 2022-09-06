using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using AutoMapper;


namespace Billing.Service.Services.Implementations
{
    public class EntidadeService : BaseService<Entidade, EntidadeDto>, IEntidadeService
    {
        public EntidadeService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }
    }
}
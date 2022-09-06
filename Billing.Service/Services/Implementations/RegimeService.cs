using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using AutoMapper;

namespace Billing.Service.Services.Implementations
{
    public class RegimeService : BaseService<Regime, RegimeDto>, IRegimeService
    {
        public RegimeService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }
    }
}
using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using AutoMapper;

namespace Billing.Service.Services.Implementations
{
    public class LicenseService : BaseService<License, LicenseDto>, ILicenseService
    {
        public LicenseService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }
    }
}
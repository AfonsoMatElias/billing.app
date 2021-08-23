using Billing.Service.Data;
using Billing.Service.Dto;
using Billing.Service.Models;
using Billing.Service.Services.Interfaces.Base;

namespace Billing.Service.Services.Interfaces
{
    public interface IProvinciaService : IBaseService<Provincia, ProvinciaDto>
    {
        DataContext Context();
    }
}
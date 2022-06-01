using System.Threading.Tasks;
using Billing.Service.Dto;
using Billing.Service.Models;
using Billing.Service.Services.Interfaces.Base;

namespace Billing.Service.Services.Interfaces
{
    public interface ICompraService : IBaseService<Compra, CompraDto>
    {
        Task SaveAll(CompraDto[] models);
    }
}
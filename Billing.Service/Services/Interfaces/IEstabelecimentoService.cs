using System.Threading.Tasks;
using Billing.Service.Dto;
using Billing.Service.Models;
using Billing.Service.Services.Interfaces.Base;

namespace Billing.Service.Services.Interfaces
{
    public interface IEstabelecimentoService : IBaseService<Estabelecimento, EstabelecimentoDto>
    {
        Task UpdateGerente(long id, EstabelecimentoDto model);
        Task UpdateRegime(long id, EstabelecimentoDto model);
    }
}
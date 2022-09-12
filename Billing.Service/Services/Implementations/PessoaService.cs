using Billing.Service.Dto;
using Billing.Service.Data;
using Billing.Service.Models;
using Billing.Service.Services.Implementations.Base;
using Billing.Service.Services.Interfaces;
using AutoMapper;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Billing.Service.Services.Implementations
{
    public class PessoaService : BaseService<Pessoa, PessoaDto>, IPessoaService
    {
        public PessoaService(DataContext mContext, IMapper mapper) : base(mapper, mContext) { }

        public override async Task Save(PessoaDto model, bool isCommit = true)
        {
            if (model.Entidade != null) {
                var tipoEntidade = await mContext.TipoEntidade
                    .FirstOrDefaultAsync(x => x.Codigo == model.Entidade.TipoEntidadeCodigo);

                if (tipoEntidade == null)
                    throw new AppException("Código do Tipo de Entidade inválido");

                if (tipoEntidade == null)
                    throw new AppException("Código do Tipo de Entidade inválido");
                
                model.Entidade.TipoEntidadeId = tipoEntidade.Id;
            }

            await base.Save(model, isCommit);
        }
    }
}
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class EstabelecimentoDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public long ComunaId { get; set; }
        public long? GerenteId { get; set; }

        public virtual ComunaDto Comuna { get; set; }
        public virtual FuncionarioDto Gerente { get; set; }

        public virtual IEnumerable<FuncionarioDto> Funcionarios { get; set; }
        public virtual IEnumerable<CompraDto> Compras { get; set; }
    }
}

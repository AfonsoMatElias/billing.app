using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class TipoEntidadeDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual IEnumerable<PessoaDto> Pessoas { get; set; }
        public virtual IEnumerable<EntidadeDto> Entidades { get; internal set; }
    }
}

using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class TipoPessoaDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual IEnumerable<EntidadeDto> Pessoas { get; set; }
    }
}

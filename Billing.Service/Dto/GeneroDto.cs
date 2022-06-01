using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class GeneroDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<PessoaDto> Pessoas { get; set; }
    }
}

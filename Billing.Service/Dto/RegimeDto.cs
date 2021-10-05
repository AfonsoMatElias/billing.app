using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class RegimeDto : Base.Properties
    {
        
        public string uid { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<EstabelecimentoDto> Estabelecimentos { get; internal set; }
    }
}
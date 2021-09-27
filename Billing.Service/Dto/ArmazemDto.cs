using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ArmazemDto : Base.Properties
    {
        
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public long EstabelecimentoId { get; set; }
        public virtual EstabelecimentoDto Estabelecimento { get; set; }
        public virtual IEnumerable<SeccaoDto> Seccoes { get; set; }
    }
}
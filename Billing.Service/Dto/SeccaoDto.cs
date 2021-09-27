using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class SeccaoDto : Base.Properties
    {
        
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public long ArmazemId { get; set; }
        public virtual ArmazemDto Armazem { get; set; }
        public virtual IEnumerable<CompraDto> Compras { get; set; }
    }
}
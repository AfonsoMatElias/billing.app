using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class TipoProdutoDto : Base.Properties
    {
        
        public string uid { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<ProdutoDto> Produtos { get; set; }
    }
}
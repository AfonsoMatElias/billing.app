using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class TipoProduto : Base.Properties
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
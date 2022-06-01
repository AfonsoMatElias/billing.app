using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class TipoVenda : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
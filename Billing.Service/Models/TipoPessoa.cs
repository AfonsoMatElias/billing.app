using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class TipoPessoa : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Entidade> Pessoas { get; set; }
    }
}
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Regime : Base.Properties
    {
        public string Nome { get; set; }
        
        public virtual ICollection<Estabelecimento> Estabelecimentos { get; internal set; }
    }
}
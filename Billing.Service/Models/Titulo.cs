using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Titulo : Base.Properties
    {
        public string Nome { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
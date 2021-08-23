using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class TipoEntidade : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<Entidade> Entidades { get; internal set; }
    }
}
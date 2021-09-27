using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Seccao : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public long ArmazemId { get; set; }
        
        public virtual Armazem Armazem { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
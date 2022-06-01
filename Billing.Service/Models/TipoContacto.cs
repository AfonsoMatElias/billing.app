using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class TipoContacto : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Contacto> Contactos { get; set; }
    }
}
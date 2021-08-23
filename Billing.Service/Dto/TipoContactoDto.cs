using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class TipoContactoDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual IEnumerable<ContactoDto> Contactos { get; set; }
    }
}

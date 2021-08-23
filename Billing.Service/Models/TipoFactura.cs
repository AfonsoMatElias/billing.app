using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class TipoFactura : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
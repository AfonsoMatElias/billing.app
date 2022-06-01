using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class TipoFacturaDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual IEnumerable<FacturaDto> Facturas { get; set; }
    }
}

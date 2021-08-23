using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class VendaDto : Base.Properties
    {
        public string uid { get; set; }
        public long? ClienteId { get; set; }
        public decimal Total { get; set; }
        public string Referencia { get; set; }
        public bool? IsPausada { get; set; }

        public virtual FacturaDto Factura { get; set; }

        public virtual EntidadeDto Cliente { get; set; }
        public virtual IEnumerable<VendaItemDto> VendaItens { get; set; }
    }
}

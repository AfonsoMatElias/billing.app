using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class VendaDto : Base.Properties
    {
        
        public string uid { get; set; }
        public long? ClienteId { get; set; }
        public long? FormaPagamentoId { get; set; }
        public decimal Total { get; set; }
        public string Referencia { get; set; }
        public long TipoVendaId { get; internal set; }
        public string CodigoTipoVenda { get; set; }
        public bool? IsPausada { get; set; }

        public virtual int TotalVendaItens { get; set; }
        
        public virtual FacturaDto Factura { get; set; }
        public virtual FormaPagamentoDto FormaPagamento { get; set; }
        public virtual EntidadeDto Cliente { get; set; }
        public virtual TipoVendaDto TipoVenda { get; internal set; }
        public virtual IEnumerable<VendaItemDto> VendaItens { get; set; }
    }
}
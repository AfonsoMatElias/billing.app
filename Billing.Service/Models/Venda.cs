using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Venda : Base.Properties
    {
        public long? ClienteId { get; set; }
        public long? FormaPagamentoId { get; set; }
        public decimal Total { get; set; }
        public string Referencia { get; set; }
        public bool? IsPausada { get; set; }

        public virtual Factura Factura { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual Entidade Cliente { get; set; }
        public virtual ICollection<VendaItem> VendaItens { get; set; }
    }
}
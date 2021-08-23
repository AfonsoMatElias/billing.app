namespace Billing.Service.Models
{
    public class Factura : Base.Properties
    {
        public long VendaId { get; set; }
        public string Referencia { get; set; }
        public long TipoFacturaId { get; set; }

        public virtual Venda Venda { get; set; }
        public virtual TipoFactura TipoFactura { get; set; }
    }
}
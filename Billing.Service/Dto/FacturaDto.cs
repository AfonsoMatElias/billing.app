namespace Billing.Service.Dto
{
    public class FacturaDto : Base.Properties
    {
        public string uid { get; set; }
        public long VendaId { get; set; }
        public string Referencia { get; set; }
        public long TipoFacturaId { get; set; }

        public virtual VendaDto Venda { get; set; }
        public virtual TipoFacturaDto TipoFactura { get; set; }
    }
}

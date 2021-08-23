namespace Billing.Service.Dto
{
    public class VendaItemDto : Base.Properties
    {
        public string uid { get; set; }
        public long VendaId { get; set; }
        public long ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }

        public virtual VendaDto Venda { get; set; }
        public virtual ProdutoDto Produto { get; set; }
    }
}

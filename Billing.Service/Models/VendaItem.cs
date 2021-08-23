namespace Billing.Service.Models
{
    public class VendaItem : Base.Properties
    {
        public long VendaId { get; set; }
        public long ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }

        public virtual Venda Venda { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
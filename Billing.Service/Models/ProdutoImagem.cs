namespace Billing.Service.Models
{
    public class ProdutoImagem : Base.Properties
    {
        public string ImageUrl { get; set; }
        public long ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
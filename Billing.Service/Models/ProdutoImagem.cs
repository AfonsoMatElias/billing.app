namespace Billing.Service.Models
{
    public class ProdutoImagem : Base.ImageProperties
    {
        public long ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
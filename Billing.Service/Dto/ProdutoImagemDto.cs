namespace Billing.Service.Dto
{
    public class ProdutoImagemDto : Base.Properties
    {
        public string uid { get; set; }
        public string ImageUrl { get; set; }
        public long ProdutoId { get; set; }

        public virtual ProdutoDto Produto { get; set; }
    }
}

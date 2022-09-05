namespace Billing.Service.Dto
{
	public class ProdutoImagemDto : Base.ImageProperties
	{
		public string uid { get; set; }
		public string DownloadUrl { get; set; }
		public long ProdutoId { get; set; }

		public virtual ProdutoDto Produto { get; set; }
	}
}

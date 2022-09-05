namespace Billing.Service.Dto
{
    public class PessoaImagemDto : Base.ImageProperties
    {
        public string uid { get; set; }
        public long PessoaId { get; set; }
		public string DownloadUrl { get; set; }

        public virtual PessoaDto Pessoa { get; set; }
    }
}
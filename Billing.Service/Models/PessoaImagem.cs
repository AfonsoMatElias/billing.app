namespace Billing.Service.Models
{
    public class PessoaImagem : Base.ImageProperties
    {
        public long PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
namespace Billing.Service.Models
{
    public class Endereco : Base.Properties
    {
        public string Rua { get; set; }
        public string Casa { get; set; }
        public string Bairro { get; set; }
        public long ComunaId { get; set; }
        public long PessoaId { get; set; }
        public bool IsPrincipal { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Comuna Comuna { get; set; }
    }
}
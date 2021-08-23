namespace Billing.Service.Dto
{
    public class EnderecoDto : Base.Properties
    {
        public string uid { get; set; }
        public string Rua { get; set; }
        public string Casa { get; set; }
        public string Bairro { get; set; }
        public long ComunaId { get; set; }
        public long PessoaId { get; set; }
        public bool IsPrincipal { get; set; }

        public virtual PessoaDto Pessoa { get; set; }
        public virtual ComunaDto Comuna { get; set; }
    }
}

namespace Billing.Service.Dto
{
    public class FuncionarioDto : Base.Properties
    {
        public string uid { get; set; }
        public long UsuarioId { get; set; }
        public long EstabelecimentoId { get; set; }

        public virtual UsuarioDto Usuario { get; set; }
        public virtual EstabelecimentoDto Estabelecimento { get; set; }
        public virtual EstabelecimentoDto EstabelecimentoGerente { get; set; }
    }
}

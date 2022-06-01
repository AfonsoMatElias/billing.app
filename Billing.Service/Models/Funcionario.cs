namespace Billing.Service.Models
{
    public class Funcionario : Base.Properties
    {
        public long UsuarioId { get; set; }
        public long EstabelecimentoId { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Estabelecimento Estabelecimento { get; set; }
        public virtual Estabelecimento EstabelecimentoGerente { get; set; }
    }
}
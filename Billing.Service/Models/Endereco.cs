using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Endereco : Base.Properties
    {
        public long PaisId { get; set; }
        public string Porta { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Detalhado { get; set; }
        public string CodigoPostal { get; set; }

        public virtual Pais Pais { get; set; }
        
        public virtual ICollection<Entidade> EntidadeEnderecoFacturacao { get; internal set; }
        public virtual ICollection<Entidade> EntidadeEnderecoExpedocao { get; internal set; }

        public virtual ICollection<Estabelecimento> Estabelecimentos { get; internal set; }
    }
}
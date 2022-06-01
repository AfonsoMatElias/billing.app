using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class MotivoIsencao : Base.Properties
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Classificacao { get; set; }
        
        public virtual ICollection<ProdutoMotivoIsencao> ProdutoMotivoIsencoes { get; set; }
    }
}
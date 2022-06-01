using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class MotivoIsencaoDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Classificacao { get; set; }
        
        public virtual IEnumerable<ProdutoMotivoIsencaoDto> ProdutoMotivoIsencoes { get; set; }
    }
}

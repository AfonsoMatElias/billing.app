using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ProdutoMotivoIsencaoDto : Base.Properties
    {
        public string uid { get; set; }
        public long ProdutoId { get; set; }
        public long MotivoIsencaoId { get; set; }

        public ProdutoDto Produto { get; set; }
        public MotivoIsencaoDto MotivoIsencao { get; set; }
    }
}

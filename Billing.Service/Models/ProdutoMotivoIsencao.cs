using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class ProdutoMotivoIsencao : Base.Properties
    {
        public long ProdutoId { get; set; }
        public long MotivoIsencaoId { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual MotivoIsencao MotivoIsencao { get; set; }
    }
}
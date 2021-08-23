using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class ProdutoMotivoIsencao : Base.Properties
    {
        public long ProdutoId { get; set; }
        public long MotivoIsencaoId { get; set; }

        public Produto Produto { get; set; }
        public MotivoIsencao MotivoIsencao { get; set; }
    }
}
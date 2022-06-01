using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class SubCategoriaDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public long CategoriaId { get; set; }

        public virtual CategoriaDto Categoria { get; set; }

        public virtual IEnumerable<ProdutoDto> Produtos { get; set; }
    }
}

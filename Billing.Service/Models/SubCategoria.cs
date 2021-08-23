using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class SubCategoria : Base.Properties
    {
        public string Nome { get; set; }
        public long CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
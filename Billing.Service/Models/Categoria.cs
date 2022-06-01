using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Categoria : Base.Properties
    {
        public string Nome { get; set; }
        
        public virtual ICollection<SubCategoria> SubCategorias { get; set; }
    }
}
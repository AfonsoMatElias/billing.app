using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class CategoriaDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        
        public virtual IEnumerable<SubCategoriaDto> SubCategorias { get; set; }
    }
}

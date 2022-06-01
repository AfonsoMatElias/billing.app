using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ProvinciaDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        
        public virtual IEnumerable<MunicipioDto> Municipios { get; set; }
    }
}

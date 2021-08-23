using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class MunicipioDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public long ProvinciaId { get; set; }
        
        public virtual ProvinciaDto Provincia { get; set; }

        public virtual IEnumerable<ComunaDto> Comunas { get; set; }
    }
}

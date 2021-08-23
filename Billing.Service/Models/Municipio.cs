using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Municipio : Base.Properties
    {
        public string Nome { get; set; }
        public long ProvinciaId { get; set; }
        
        public virtual Provincia Provincia { get; set; }

        public virtual ICollection<Comuna> Comunas { get; set; }
    }
}
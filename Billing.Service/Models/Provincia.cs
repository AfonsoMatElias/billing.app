using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Provincia : Base.Properties
    {
        public string Nome { get; set; }
        
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
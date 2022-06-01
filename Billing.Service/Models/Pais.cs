using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Pais : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
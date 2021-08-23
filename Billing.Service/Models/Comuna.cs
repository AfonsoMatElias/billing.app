using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Comuna : Base.Properties
    {
        public string Nome { get; set; }
        public long MunicipioId { get; set; }

        public virtual Municipio Municipio { get; set; }
        public ICollection<Estabelecimento> Estabelecimentos { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
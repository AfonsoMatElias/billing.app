using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class PaisDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual IEnumerable<EnderecoDto> Enderecos { get; set; }
    }
}
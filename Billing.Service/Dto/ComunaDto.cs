using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ComunaDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public long MunicipioId { get; set; }

        public virtual MunicipioDto Municipio { get; set; }
        public ICollection<EstabelecimentoDto> Estabelecimentos { get; set; }
        public ICollection<EnderecoDto> Enderecos { get; set; }
    }
}

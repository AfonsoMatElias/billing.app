using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class EnderecoDto : Base.Properties
    {
        
        public string uid { get; set; }
        public long PaisId { get; set; }
        public string Porta { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Detalhado { get; set; }
        public string CodigoPostal { get; set; }
        public virtual PaisDto Pais { get; set; }
        public virtual IEnumerable<EntidadeDto> EntidadeEnderecoFacturacao { get; internal set; }
        public virtual IEnumerable<EntidadeDto> EntidadeEnderecoExpedocao { get; internal set; }
        public virtual IEnumerable<EstabelecimentoDto> Estabelecimentos { get; internal set; }
    }
}
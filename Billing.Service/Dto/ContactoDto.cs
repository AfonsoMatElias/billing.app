using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ContactoDto : Base.Properties
    {
        public string uid { get; set; }
        public string Contaco { get; set; }
        public long PessoaId { get; set; }
        public long TipoContactoId { get; set; }
        
        public virtual PessoaDto Pessoa { get; set; }
        public virtual TipoContactoDto TipoContacto { get; set; }
    }
}

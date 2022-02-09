using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Contacto : Base.Properties
    {
        public string Valor { get; set; }
        public long PessoaId { get; set; }
        public long TipoContactoId { get; set; }
        
        public virtual Pessoa Pessoa { get; set; }
        public virtual TipoContacto TipoContacto { get; set; }
    }
}
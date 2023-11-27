using System.Collections.Generic;

namespace Billing.Service.Models
{

    public class Armazem<T> : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public long EstabelecimentoId { get; set; }

        public virtual Estabelecimento Estabelecimento { get; set; }
        
        public virtual ICollection<Seccao> Seccoes { get; set; }
    }

    public class Armazem : Base.Properties
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public long EstabelecimentoId { get; set; }

        public virtual Estabelecimento Estabelecimento { get; set; }
        
        public virtual ICollection<Seccao> Seccoes { get; set; }
    }
}
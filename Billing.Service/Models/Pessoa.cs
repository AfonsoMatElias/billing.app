using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Pessoa : Base.Properties
    {
        public DateTime DataNascimento { get; set; }
        public string Identificacao { get; set; }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public long? TituloId { get; set; }
        public long? GeneroId { get; set; }

        public virtual Titulo Titulo { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Entidade Entidade { get; set; }
        public virtual PessoaImagem PessoaImagem { get; set; }
        public virtual ICollection<Contacto> Contactos { get; set; }
    }
}
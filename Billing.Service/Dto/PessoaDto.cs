using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class PessoaDto : Base.Properties
    {
        public string uid { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Identificacao { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public long? TituloId { get; set; }
        public long? GeneroId { get; set; }

        public virtual TituloDto Titulo { get; set; }
        public virtual GeneroDto Genero { get; set; }
        public virtual PessoaImagemDto PessoaImagem { get; set; }
        public virtual UsuarioDto Usuario { get; set; }
        public virtual EntidadeDto Entidade { get; set; }
        public virtual IEnumerable<EnderecoDto> Enderecos { get; set; }
        public virtual IEnumerable<ContactoDto> Contactos { get; set; }
    }
}

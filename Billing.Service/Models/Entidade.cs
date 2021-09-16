using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Entidade : Base.Properties
    {
        public long PessoaId { get; set; }
        public long TipoEntidadeId { get; set; }
        public long EnderecoFacturacaoId { get; set; }
        public long EnderecoExpedicaoId { get; set; }

        public string NomeEmpresa { get; set; }
        public string NomePessoaContactoEmpresa { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual TipoEntidade TipoEntidade { get; set; }

        public virtual Endereco EnderecoFacturacao { get; set; }
        public virtual Endereco EnderecoExpedicao { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class EntidadeDto : Base.Properties
    {
        
        public string uid { get; set; }
        public long PessoaId { get; set; }
        public long TipoEntidadeId { get; set; }
        public long EnderecoFacturacaoId { get; set; }
        public long EnderecoExpedicaoId { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomePessoaContactoEmpresa { get; set; }
        public string TipoEntidadeCodigo { get; internal set; }
        public virtual PessoaDto Pessoa { get; set; }
        public virtual TipoEntidadeDto TipoEntidade { get; set; }
        public virtual EnderecoDto EnderecoFacturacao { get; set; }
        public virtual EnderecoDto EnderecoExpedicao { get; set; }
        public virtual IEnumerable<CompraDto> Compras { get; set; }
        public virtual IEnumerable<VendaDto> Vendas { get; set; }
    }
}
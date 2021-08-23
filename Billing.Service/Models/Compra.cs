using System;

namespace Billing.Service.Models
{
    public class Compra : Base.Properties
    {
        public long? FornecedorId { get; set; }
        public long ProdutoId { get; set; }
        public long EstabelecimentoId { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int PrecoUnitarioCompra { get; set; }
        public int PrecoUnitarioVenda { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataValidade { get; set; }
        public bool IsActiva { get; set; }

        public virtual Entidade Fornecedor { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Estabelecimento Estabelecimento { get; set; }
    }
}
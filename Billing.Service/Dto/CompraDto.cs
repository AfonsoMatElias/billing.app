using System;

namespace Billing.Service.Dto
{
    public class CompraDto : Base.Properties
    {
        public string uid { get; set; }
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

        public virtual EntidadeDto Fornecedor { get; set; }
        public virtual ProdutoDto Produto { get; set; }
        public virtual EstabelecimentoDto Estabelecimento { get; set; }
    }
}

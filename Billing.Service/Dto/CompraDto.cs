using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class CompraDto : Base.Properties
    {
        
        public string uid { get; set; }
        public long? FornecedorId { get; set; }
        public long ProdutoId { get; set; }
        public long? EstabelecimentoId { get; set; }
        public int Quantidade { get; set; } // A quantidade que será reduzida a cada venda
        public int QuantidadeEntrada { get; set; } // Registra a quantidade inicial inserida
        public int? StockMinimo { get; set; }
        public int PrecoUnitarioCompra { get; set; }
        public int PrecoUnitarioVenda { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataValidade { get; set; }
        public bool IsActiva { get; set; }
        public long? SeccaoId { get; set; }
        public virtual EntidadeDto Fornecedor { get; set; }
        public virtual ProdutoDto Produto { get; set; }
        public virtual EstabelecimentoDto Estabelecimento { get; set; }
        public virtual SeccaoDto Seccao { get; set; }
    }
}
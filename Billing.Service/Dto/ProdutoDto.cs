using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ProdutoDto : Base.Properties
    {
        public string uid { get; set; }
        public string Nome { get; set; }
        public string NomeSecundario { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal IVA { get; set; }
        public long SubCategoriaId { get; set; }
        public bool IsPerecivel { get; set; }
        public bool IsStock { get; set; }

        public virtual SubCategoriaDto SubCategoria { get; set; }

        public virtual IEnumerable<CompraDto> Compras { get; set; }
        public virtual IEnumerable<ProdutoImagemDto> ProdutoImagens { get; set; }
        public virtual IEnumerable<VendaItemDto> VendaItens { get; set; }
        public virtual IEnumerable<ProdutoMotivoIsencaoDto> ProdutoMotivoIsencoes { get; set; }
    }
}

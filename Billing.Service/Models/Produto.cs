using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Produto : Base.Properties
    {
        public string Nome { get; set; }
        public string NomeSecundario { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal IVA { get; set; } = 0;
        public long SubCategoriaId { get; set; }
        public bool IsPerecivel { get; set; }
        public bool IsStock { get; set; }

        public virtual SubCategoria SubCategoria { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<ProdutoImagem> ProdutoImagens { get; set; }
        public virtual ICollection<VendaItem> VendaItens { get; set; }
        public virtual ICollection<ProdutoMotivoIsencao> ProdutoMotivoIsencoes { get; set; }
    }
}
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Estabelecimento : Base.Properties
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public long ComunaId { get; set; }
        public long? GerenteId { get; set; }

        public virtual Comuna Comuna { get; set; }
        public virtual Funcionario Gerente { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
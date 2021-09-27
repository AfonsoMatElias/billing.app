using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Estabelecimento : Base.Properties
    {
        public string Nome { get; set; }
        public long EnderecoId { get; set; }
        public long? GerenteId { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual Funcionario Gerente { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Armazem> Armazens { get; set; }
    }
}
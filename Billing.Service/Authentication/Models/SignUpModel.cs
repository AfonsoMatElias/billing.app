using System;

namespace Billing.Service.Authentication
{
    public class SignUpModel
    {
        public string[] Roles { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long EstabelecimentoId { get; set; }

        public string Identificacao { get; set; }
        public DateTime DataNascimento { get; set; }

        public long TituloId { get; set; }
        public long GeneroId { get; set; }
    }
}
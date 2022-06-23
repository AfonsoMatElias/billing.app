using System;

namespace Billing.Service.Authentication
{
    public class AccountModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public dynamic User { get; set; }
        public dynamic Preferences { get; set; }
        public bool HasEstabelecimento { get; set; }
        public long? EstabelecimentoId { get; set; }
    }
}
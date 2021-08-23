using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Billing.Service.Models
{
    public class Usuario : IdentityUser<long>
    {
        public bool? Visibility { get; set; } = true;
        public string Codigo { get; set; }
        public long? PessoaId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<ChatMessage> ChatMessagesFrom { get; set; }
        public virtual ICollection<ChatMessage> ChatMessagesTo { get; set; }
    }
}
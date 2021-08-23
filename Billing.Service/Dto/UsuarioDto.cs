using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Billing.Service.Dto
{
    public class UsuarioDto
    {
        public string uid { get; set; }
        public bool? Visibility { get; set; } = true;
        public string Codigo { get; set; }
        public long? PessoaId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual PessoaDto Pessoa { get; set; }
        public virtual FuncionarioDto Funcionario { get; set; }

        public virtual IEnumerable<ChatDto> Chats { get; set; }
        public virtual IEnumerable<ChatMessageDto> ChatMessagesFrom { get; set; }
        public virtual IEnumerable<ChatMessageDto> ChatMessagesTo { get; set; }
    }
}

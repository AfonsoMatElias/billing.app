using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class ChatMessage
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public String Content { get; set; }
        public bool? Visibility { get; set; } = true;
        public long UsuarioToId { get; set; }
        public long UsuarioFromId { get; set; }

        public virtual Usuario UsuarioTo { get; set; }
        public virtual Usuario UsuarioFrom { get; set; }

        public virtual ICollection<ChatMessageAttachment> ChatMessageAttachments { get; set; }
    }
}
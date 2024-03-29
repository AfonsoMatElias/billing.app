using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class ChatMessage : Base.Properties
    {
        public String Content { get; set; }
        public long ChatId { get; set; }
        public long UsuarioToId { get; set; }
        public long UsuarioFromId { get; set; }

        public virtual Chat Chat { get; set; }
        public virtual Usuario UsuarioTo { get; set; }
        public virtual Usuario UsuarioFrom { get; set; }

        public virtual ICollection<ChatMessageAttachment> ChatMessageAttachments { get; set; }
    }
}
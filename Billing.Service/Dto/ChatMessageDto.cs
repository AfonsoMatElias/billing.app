using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ChatMessageDto
    {
        public string uid { get; set; }
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public String Content { get; set; }
        public bool? Visibility { get; set; } = true;
        public long UsuarioToId { get; set; }
        public long UsuarioFromId { get; set; }

        public virtual UsuarioDto UsuarioTo { get; set; }
        public virtual UsuarioDto UsuarioFrom { get; set; }

        public virtual IEnumerable<ChatMessageAttachmentDto> ChatMessageAttachments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Billing.Service.Dto
{
    public class ChatDto : Base.Properties
    {
        public string uid { get; set; }
        public string Referencia { get; set; }
        public long CriadorId { get; set; }
        
        public virtual UsuarioDto Criador { get; set; }
        public virtual IEnumerable<ChatMessageDto> ChatMessages { get; set; }
    }
}

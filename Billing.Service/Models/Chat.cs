using System;
using System.Collections.Generic;

namespace Billing.Service.Models
{
    public class Chat : Base.Properties
    {
        public string Referencia { get; set; }
        public long CriadorId { get; set; }
        
        public virtual Usuario Criador { get; set; }
        public virtual ICollection<ChatMessage> ChatMessages { get; set; }
    }
}
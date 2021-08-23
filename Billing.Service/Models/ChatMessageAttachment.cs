namespace Billing.Service.Models
{
    public class ChatMessageAttachment : Base.Properties 
    {
        public string FileUrl { get; set; }
        public long ChatMessageId { get; set; }

        public virtual ChatMessage ChatMessage { get; set; }
    }
}
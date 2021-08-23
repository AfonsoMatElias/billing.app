namespace Billing.Service.Dto
{
    public class ChatMessageAttachmentDto : Base.Properties 
    {
        public string uid { get; set; }
        public string FileUrl { get; set; }
        public long ChatMessageId { get; set; }

        public virtual ChatMessageDto ChatMessage { get; set; }
    }
}

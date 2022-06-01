using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Billing.Service.Data.Configurations
{
    public class ChatMessageAttachmentConfig : IEntityTypeConfiguration<ChatMessageAttachment>
    {
        public void Configure(EntityTypeBuilder<ChatMessageAttachment> builder)
        {
            new BaseConfig().Configure(builder);
    
            builder.Property(e => e.FileUrl)
                    .IsRequired()
                    .HasMaxLength(800);
    
            builder.Property(e => e.ChatMessageId)
                    .IsRequired();
    
            builder.HasOne(e => e.ChatMessage)
                   .WithMany(e => e.ChatMessageAttachments)
                   .HasForeignKey(e => e.ChatMessageId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
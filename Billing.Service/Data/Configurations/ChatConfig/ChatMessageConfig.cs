using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Billing.Service.Data.Configurations
{
    public class ChatMessageConfig : IEntityTypeConfiguration<ChatMessage>
    {
        public void Configure(EntityTypeBuilder<ChatMessage> builder)
        {
            new BaseConfig().Configure(builder);
    
            builder.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(4056)
                    .IsUnicode(false);

            builder.HasOne(e => e.UsuarioFrom)
                    .WithMany(e => e.ChatMessagesFrom)
                    .HasForeignKey(e => e.UsuarioFromId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.UsuarioTo)
                    .WithMany(e => e.ChatMessagesTo)
                    .HasForeignKey(e => e.UsuarioToId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.Chat)
                    .WithMany(e => e.ChatMessages)
                    .HasForeignKey(e => e.ChatId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }
}
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
    
            builder.Property(e => e.UsuarioFromId)
                    .IsRequired();
    
            builder.Property(e => e.UsuarioToId)
                    .IsRequired();

            builder.HasOne(e => e.UsuarioFrom)
                    .WithMany(e => e.ChatMessagesFrom)
                    .HasForeignKey(e => e.UsuarioFromId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.UsuarioTo)
                    .WithMany(e => e.ChatMessagesTo)
                    .HasForeignKey(e => e.UsuarioToId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
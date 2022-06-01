using System;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class ChatConfig : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.HasOne(e => e.Criador)
                    .WithMany(e => e.Chats)
                    .HasForeignKey(e => e.CriadorId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
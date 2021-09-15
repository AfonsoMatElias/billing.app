using System.Collections.Generic;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class VendaConfig : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Total)
                    .HasPrecision(18, 2)
                    .IsRequired();

            builder.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsRequired();

            builder.Property(e => e.IsPausada)
                    .IsRequired(false);

            builder.Property(e => e.ClienteId)
                    .IsRequired(false);

            builder.HasOne(e => e.Cliente)
                    .WithMany(e => e.Vendas)
                    .HasForeignKey(e => e.ClienteId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.FormaPagamento)
                    .WithMany(e => e.Vendas)
                    .HasForeignKey(e => e.FormaPagamentoId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
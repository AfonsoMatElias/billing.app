using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class VendaItemConfig : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.VendaId)
                    .IsRequired();

            builder.Property(e => e.ProdutoId)
                    .IsRequired();

            builder.Property(e => e.Quantidade)
                    .IsRequired();

            builder.Property(e => e.Preco)
                    .HasPrecision(18, 2)
                    .IsRequired();

            builder.Property(e => e.Desconto)
                    .HasPrecision(18, 2)
                    .IsRequired();

            builder.HasOne(e => e.Venda)
                    .WithMany(e => e.VendaItens)
                    .HasForeignKey(e => e.VendaId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Produto)
                    .WithMany(e => e.VendaItens)
                    .HasForeignKey(e => e.ProdutoId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
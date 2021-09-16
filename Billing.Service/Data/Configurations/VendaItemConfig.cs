using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class VendaItemConfig : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            new BaseConfig().Configure(builder);

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
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.Produto)
                    .WithMany(e => e.VendaItens)
                    .HasForeignKey(e => e.ProdutoId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }
}
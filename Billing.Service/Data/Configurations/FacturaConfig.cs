using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class FacturaConfig : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsRequired();

            builder.HasOne(e => e.Venda)
                    .WithOne(e => e.Factura)
                    .HasForeignKey<Factura>(e => e.VendaId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.TipoFactura)
                    .WithMany(e => e.Facturas)
                    .HasForeignKey(e => e.TipoFacturaId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }
}
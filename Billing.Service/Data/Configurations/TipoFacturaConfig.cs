using System.Linq;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class TipoFacturaConfig : IEntityTypeConfiguration<TipoFactura>
    {
        public void Configure(EntityTypeBuilder<TipoFactura> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.Codigo)
                    .HasMaxLength(3);

            builder.HasData(this.TableSeed());
        }

        internal TipoFactura[] TableSeed()
        {
            return (new[] {
                "Factura a Pronto Pagamento:fpp",
                "Factura Proforma:fpf"
            }).Select((item, index) => {
                var values = item.Split(':');
                return new TipoFactura {
                    Id = (index + 1),
                    Nome = values.FirstOrDefault(),
                    Codigo = values.LastOrDefault()
                };
            }).ToArray();
        }
    }
}
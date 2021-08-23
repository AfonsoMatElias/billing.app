using System.Linq;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class TipoVendaConfig : IEntityTypeConfiguration<TipoVenda>
    {
        public void Configure(EntityTypeBuilder<TipoVenda> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.Codigo)
                    .HasMaxLength(3);

            builder.HasData(this.TableSeed());
        }

        internal TipoVenda[] TableSeed()
        {
            return (new[] {
                "Venda a Pronto Pagamento:vpp",
                "Venda a Credito:vc"
            }).Select((item, index) => {
                var values = item.Split(':');
                return new TipoVenda {
                    Id = (index + 1),
                    Nome = values.FirstOrDefault(),
                    Codigo = values.LastOrDefault()
                };
            }).ToArray();
        }
    }
}
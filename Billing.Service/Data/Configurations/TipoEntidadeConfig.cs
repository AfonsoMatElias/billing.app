using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class TipoEntidadeConfig : IEntityTypeConfiguration<TipoEntidade>
    {
        public void Configure(EntityTypeBuilder<TipoEntidade> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.Codigo)
                    .HasMaxLength(3);

            builder.HasData(this.TableSeed());
        }

        internal TipoEntidade[] TableSeed()
        {
            return (new[] {
                "Cliente:tec",
                "Fornecedor:tef"
            }).Select((item, index) => {
                var values = item.Split(':');
                return new TipoEntidade {
                    Id = (index + 1),
                    Nome = values.FirstOrDefault(),
                    Codigo = values.LastOrDefault()
                };
            }).ToArray();
        }
    }
}
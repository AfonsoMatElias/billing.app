using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class TipoPessoaConfig : IEntityTypeConfiguration<TipoPessoa>
    {
        public void Configure(EntityTypeBuilder<TipoPessoa> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.Codigo)
                    .HasMaxLength(3);

            builder.HasData(this.TableSeed());
        }

        internal TipoPessoa[] TableSeed()
        {
            return (new[]{
                "Pessoa Singular:tps",
                "Pessoa Colectiva:tpc"
            }).Select((item, index) => {
                var values = item.Split(':');
                return new TipoPessoa {
                    Id = (index + 1),
                    Nome = values.FirstOrDefault(),
                    Codigo = values.LastOrDefault()
                };
            }).ToArray();
        }
    }
}
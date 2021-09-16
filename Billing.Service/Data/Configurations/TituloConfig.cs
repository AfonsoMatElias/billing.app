using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class TituloConfig : IEntityTypeConfiguration<Titulo>
    {
        public void Configure(EntityTypeBuilder<Titulo> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.HasData(this.TableSeed());
        }

        internal Titulo[] TableSeed()
        {
            return (new[]{
                "Sr.",
                "Sra."
            }).Select((item, index) => {
                return new Titulo {
                    Id = (index + 1),
                    Nome = item
                };
            }).ToArray();
        }
    }
}
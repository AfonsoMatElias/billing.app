using System.Linq;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class TipoContactoConfig : IEntityTypeConfiguration<TipoContacto>
    {
        public void Configure(EntityTypeBuilder<TipoContacto> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.Codigo)
                    .HasMaxLength(3);

            builder.HasData(this.TableSeed());
        }

        internal TipoContacto[] TableSeed()
        {
            return (new[]{
                "Telefone",
                "Email",
                "Fax"
            }).Select((item, index) => {
                return new TipoContacto {
                    Id = (index + 1),
                    Nome = item,
                    Codigo = (index + 1).ToString().PadLeft(2, '0')
                };
            }).ToArray();
        }
    }
}
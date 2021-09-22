using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class PaisConfig : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            new BaseConfig().Configure(builder);
    
            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();
    
            builder.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsRequired();

            builder.HasData(this.TableSeed());
        }

        internal Pais[] TableSeed()
        {
           return (new[] {
                "Angola:AO",
            }).Select((item, index) => {
                var values = item.Split(':');
                return new Pais {
                    Id = (index + 1),
                    Nome = values.FirstOrDefault(),
                    Codigo = values.LastOrDefault()
                };
            }).ToArray();
        }
    }
}
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class ComunaConfig : IEntityTypeConfiguration<Comuna>
    {
        public void Configure(EntityTypeBuilder<Comuna> builder)
        {
            new BaseConfig().Configure(builder);
    
            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();
    
            builder.Property(e => e.MunicipioId)
                    .IsRequired();

            builder.HasOne(e => e.Municipio)
                    .WithMany(e => e.Comunas)
                    .HasForeignKey(e => e.MunicipioId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
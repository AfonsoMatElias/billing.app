using System;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class MunicipioConfig : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.ProvinciaId)
                    .IsRequired();

            builder.HasOne(e => e.Provincia)
                    .WithMany(e => e.Municipios)
                    .HasForeignKey(e => e.ProvinciaId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
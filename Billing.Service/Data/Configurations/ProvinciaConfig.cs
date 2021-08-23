using System;
using System.Linq;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class ProvinciaConfig : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();
        }
    }
}
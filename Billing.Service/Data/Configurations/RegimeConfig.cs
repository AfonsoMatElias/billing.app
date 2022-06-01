using System;
using System.Collections.Generic;
using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class RegimeConfig : IEntityTypeConfiguration<Regime>
    {
        public void Configure(EntityTypeBuilder<Regime> builder)
        {
            new BaseConfig().Configure(builder);
            
            builder.Property(e => e.Nome)
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.HasData(this.TableSeed());
        }

        internal Regime[] TableSeed()
        {
            return (new[] {
                "Simplificado",
                "Especial",
                "Geral"
            }).Select((item, index) => {
                return new Regime {
                    Id = (index + 1),
                    Nome = item,
                };
            }).ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Billing.Service.Data.Configurations;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsRequired();

            builder.HasData(this.TableSeed());
        }

        internal Genero[] TableSeed()
        {
            return (new[] {
                "Masculino",
                "Feminino",
                "N/A",
            }).Select((item, index) =>
                {
                    return new Genero
                    {
                        Id = (index + 1),
                        Nome = item
                    };
                }).ToArray();
        }
    }
}
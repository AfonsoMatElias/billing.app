using System;
using System.Collections.Generic;
using System.Linq;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
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
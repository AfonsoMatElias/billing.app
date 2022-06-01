using System;
using System.Collections.Generic;
using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class SeccaoConfig : IEntityTypeConfiguration<Seccao>
    {
        public void Configure(EntityTypeBuilder<Seccao> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.Property(e => e.Codigo)
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.HasOne(e => e.Armazem)
                   .WithMany(e => e.Seccoes)
                   .HasForeignKey(e => e.ArmazemId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class ArmazemConfig : IEntityTypeConfiguration<Armazem>
    {
        public void Configure(EntityTypeBuilder<Armazem> builder)
        {
            new BaseConfig().Configure(builder);
            
            builder.Property(e => e.Nome)
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.Property(e => e.Codigo)
                   .HasMaxLength(200)
                   .IsRequired(false);
            
            builder.HasOne(e => e.Estabelecimento)
                    .WithMany(e => e.Armazens)
                    .HasForeignKey(e => e.EstabelecimentoId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
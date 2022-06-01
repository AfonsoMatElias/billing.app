using System;
using System.Collections.Generic;
using System.Linq;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class MotivoIsencaoConfig : IEntityTypeConfiguration<MotivoIsencao>
    {
        public void Configure(EntityTypeBuilder<MotivoIsencao> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsRequired(false);

            builder.Property(e => e.Classificacao)
                    .HasMaxLength(100)
                    .IsRequired(false);
        }
    }
}
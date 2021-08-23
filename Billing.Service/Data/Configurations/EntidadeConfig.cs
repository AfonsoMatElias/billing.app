using System;
using System.Collections.Generic;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class EntidadeConfig : IEntityTypeConfiguration<Entidade>
    {
        public void Configure(EntityTypeBuilder<Entidade> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.PessoaId)
                    .IsRequired();

            builder.Property(e => e.TipoEntidadeId)
                    .IsRequired();

            builder.Property(e => e.TipoPessoaId)
                    .IsRequired();

            // Relations         
            builder.HasOne(e => e.TipoEntidade)
                    .WithMany(e => e.Entidades)
                    .HasForeignKey(e => e.TipoEntidadeId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.TipoPessoa)
                    .WithMany(e => e.Pessoas)
                    .HasForeignKey(e => e.TipoPessoaId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Pessoa)
                    .WithOne(e => e.Entidade)
                    .HasForeignKey<Entidade>(e => e.PessoaId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
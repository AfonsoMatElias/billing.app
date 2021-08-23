using System;
using System.Collections.Generic;
using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            new BaseConfig().Configure(builder);

            // Pessoa Base
            builder.Property(e => e.ProfileImageUrl)
                    .HasMaxLength(500);

            builder.Property(e => e.DataNascimento)
                    .IsRequired();

            builder.Property(e => e.Identificacao)
                    .HasMaxLength(50)
                    .IsRequired();

            // Pessoa Singular
            builder.Property(e => e.PrimeiroNome)
                    .HasMaxLength(250)
                    .IsRequired();

            builder.Property(e => e.UltimoNome)
                    .HasMaxLength(250);

            builder.Property(e => e.TituloId)
                    .IsRequired(false);

            builder.Property(e => e.GeneroId)
                    .IsRequired(false);

            // Relations
            builder.HasOne(e => e.Titulo)
                    .WithMany(e => e.Pessoas)
                    .HasForeignKey(e => e.TituloId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Genero)
                    .WithMany(e => e.Pessoas)
                    .HasForeignKey(e => e.GeneroId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
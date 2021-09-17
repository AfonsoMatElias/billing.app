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

            builder.Property(e => e.NomeEmpresa)
                    .HasMaxLength(200)
                    .IsRequired(false);

            builder.Property(e => e.NomePessoaContactoEmpresa)
                    .HasMaxLength(200)
                    .IsRequired(false);

            // Relations         
            builder.HasOne(e => e.TipoEntidade)
                    .WithMany(e => e.Entidades)
                    .HasForeignKey(e => e.TipoEntidadeId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.Pessoa)
                    .WithOne(e => e.Entidade)
                    .HasForeignKey<Entidade>(e => e.PessoaId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.EnderecoExpedicao)
                    .WithMany(e => e.EntidadeEnderecoExpedocao)
                    .HasForeignKey(e => e.EnderecoExpedicaoId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.EnderecoFacturacao)
                    .WithMany(e => e.EntidadeEnderecoFacturacao)
                    .HasForeignKey(e => e.EnderecoFacturacaoId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();
        }
    }
}
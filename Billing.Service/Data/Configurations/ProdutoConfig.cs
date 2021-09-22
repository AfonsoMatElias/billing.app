using System.Collections.Generic;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .IsRequired();

            builder.Property(e => e.Descricao)
                    .HasMaxLength(4056);

            builder.Property(e => e.IsPerecivel)
                    .IsRequired();

            builder.Property(e => e.IsStock)
                    .IsRequired();

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.NomeSecundario)
                    .IsRequired(false)
                    .HasMaxLength(400);

            builder.Property(e => e.PrecoUnitario)
                    .HasPrecision(18, 2)
                    .IsRequired();

            builder.Property(e => e.IVA)
                    .HasPrecision(18, 2)
                    .IsRequired();

            builder.Property(e => e.SubCategoriaId)
                    .IsRequired();

            builder.HasOne(e => e.SubCategoria)
                    .WithMany(e => e.Produtos)
                    .HasForeignKey(e => e.SubCategoriaId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
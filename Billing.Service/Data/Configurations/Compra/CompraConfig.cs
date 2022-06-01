using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class CompraConfig : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.DataEntrada)
                    .IsRequired();
    
            builder.Property(e => e.DataValidade)
                    .IsRequired(false);

            builder.Property(e => e.FornecedorId)
                    .IsRequired(false);

            builder.Property(e => e.IsActiva)
                    .IsRequired();

            builder.Property(e => e.PrecoUnitarioCompra)
                    .IsRequired();

            builder.Property(e => e.PrecoUnitarioVenda)
                    .IsRequired();

            builder.Property(e => e.ProdutoId)
                    .IsRequired();

            builder.Property(e => e.Quantidade)
                    .IsRequired();

            builder.Property(e => e.QuantidadeEntrada)
                    .IsRequired();

            builder.HasOne(e => e.Fornecedor)
                    .WithMany(e => e.Compras)
                    .HasForeignKey(e => e.FornecedorId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Produto)
                    .WithMany(e => e.Compras)
                    .HasForeignKey(e => e.ProdutoId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Estabelecimento)
                    .WithMany(e => e.Compras)
                    .HasForeignKey(e => e.EstabelecimentoId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);

            builder.HasOne(e => e.Seccao)
                    .WithMany(e => e.Compras)
                    .HasForeignKey(e => e.SeccaoId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);
        }
    }
}
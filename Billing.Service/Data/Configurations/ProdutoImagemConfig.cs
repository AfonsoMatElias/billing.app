using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class ProdutoImagemConfig : IEntityTypeConfiguration<ProdutoImagem>
    {
        public void Configure(EntityTypeBuilder<ProdutoImagem> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Content)
                    .IsRequired();

            builder.Property(e => e.Extension)
                    .HasMaxLength(8)
                    .IsRequired();

            builder.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.UniqueName)
                    .HasMaxLength(80)
                    .IsRequired();

            builder.Property(e => e.ProdutoId)
                    .IsRequired();

            builder.HasOne(e => e.Produto)
                    .WithMany(e => e.ProdutoImagens)
                    .HasForeignKey(e => e.ProdutoId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
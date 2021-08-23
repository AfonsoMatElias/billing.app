using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class ProdutoImagemConfig : IEntityTypeConfiguration<ProdutoImagem>
    {
        public void Configure(EntityTypeBuilder<ProdutoImagem> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.ImageUrl)
                    .HasMaxLength(400)
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
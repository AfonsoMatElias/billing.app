using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class ProdutoMotivoIsencaoConfig : IEntityTypeConfiguration<ProdutoMotivoIsencao>
    {
        public void Configure(EntityTypeBuilder<ProdutoMotivoIsencao> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.ProdutoId)
                    .IsRequired();

            builder.Property(e => e.MotivoIsencaoId)
                    .IsRequired();

            builder.HasOne(e => e.Produto)
                    .WithMany(e => e.ProdutoMotivoIsencoes)
                    .HasForeignKey(e => e.ProdutoId)
                    .OnDelete(DeleteBehavior.NoAction);
            
            builder.HasOne(e => e.MotivoIsencao)
                    .WithMany(e => e.ProdutoMotivoIsencoes)
                    .HasForeignKey(e => e.MotivoIsencaoId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
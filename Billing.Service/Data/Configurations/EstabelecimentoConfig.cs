using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class EstabelecimentoConfig : IEntityTypeConfiguration<Estabelecimento>
    {
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {
            new BaseConfig().Configure(builder);
    
            builder.Property(e => e.GerenteId)
                    .IsRequired(false);
    
            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.HasOne(e => e.Gerente)
                    .WithOne(e => e.EstabelecimentoGerente)
                    .HasForeignKey<Estabelecimento>(e => e.GerenteId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);

            builder.HasOne(e => e.Endereco)
                    .WithMany(e => e.Estabelecimentos)
                    .HasForeignKey(e => e.EnderecoId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

            builder.HasOne(e => e.Regime)
                    .WithMany(e => e.Estabelecimentos)
                    .HasForeignKey(e => e.RegimeId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired(false);
        }
    }
}
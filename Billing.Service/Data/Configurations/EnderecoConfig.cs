using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Porta)
                    .IsRequired(false)
                    .HasMaxLength(200);
    
            builder.Property(e => e.Rua)
                    .HasMaxLength(200)
                    .IsRequired(false);

            builder.Property(e => e.Cidade)
                    .IsRequired(false)
                    .HasMaxLength(200);
    
            builder.Property(e => e.Detalhado)
                    .IsRequired(false)
                    .HasMaxLength(250);
    
            builder.Property(e => e.CodigoPostal)
                    .IsRequired(false)
                    .HasMaxLength(20);

            builder.HasOne(e => e.Pais)
                    .WithMany(e => e.Enderecos)
                    .HasForeignKey(e => e.PaisId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
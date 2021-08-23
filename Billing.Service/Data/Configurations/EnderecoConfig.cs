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
    
            builder.Property(e => e.Casa)
                    .IsRequired(false)
                    .HasMaxLength(200);
    
            builder.Property(e => e.Rua)
                    .HasMaxLength(200)
                    .IsRequired(false);
            
            builder.Property(e => e.Bairro)
                    .HasMaxLength(500)
                    .IsRequired();

            builder.HasOne(e => e.Pessoa)
                    .WithMany(e => e.Enderecos)
                    .HasForeignKey(e => e.PessoaId)
                    .OnDelete(DeleteBehavior.NoAction);
        
            builder.HasOne(e => e.Comuna)
                    .WithMany(e => e.Enderecos)
                    .HasForeignKey(e => e.ComunaId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
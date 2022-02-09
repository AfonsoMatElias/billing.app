using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class ContactoConfig : IEntityTypeConfiguration<Contacto>
    {
        public void Configure(EntityTypeBuilder<Contacto> builder)
        {
            new BaseConfig().Configure(builder);
    
            builder.Property(e => e.Valor)
                    .IsRequired(false)
                    .HasMaxLength(200);                

            builder.HasOne(e => e.Pessoa)
                    .WithMany(e => e.Contactos)
                    .HasForeignKey(e => e.PessoaId)
                    .OnDelete(DeleteBehavior.NoAction);
        
            builder.HasOne(e => e.TipoContacto)
                    .WithMany(e => e.Contactos)
                    .HasForeignKey(e => e.TipoContactoId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class FormaPagamentoConfig : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            new BaseConfig().Configure(builder);
    
            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();
    
            builder.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsRequired();
        }
    }
}
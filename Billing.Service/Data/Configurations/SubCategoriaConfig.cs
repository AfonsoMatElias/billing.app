using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
{
    public class SubCategoriaConfig : IEntityTypeConfiguration<SubCategoria>
    {
        public void Configure(EntityTypeBuilder<SubCategoria> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsRequired();

            builder.Property(e => e.CategoriaId)
                    .IsRequired();

            builder.HasOne(e => e.Categoria)
                    .WithMany(e => e.SubCategorias)
                    .HasForeignKey(e => e.CategoriaId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
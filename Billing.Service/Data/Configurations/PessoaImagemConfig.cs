using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class PessoaImagemConfig : IEntityTypeConfiguration<PessoaImagem>
    {
        public void Configure(EntityTypeBuilder<PessoaImagem> builder)
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

            builder.Property(e => e.PessoaId)
                    .IsRequired();

            builder.HasOne(e => e.Pessoa)
                    .WithOne(e => e.PessoaImagem)
                    .HasForeignKey<PessoaImagem>(e => e.PessoaId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
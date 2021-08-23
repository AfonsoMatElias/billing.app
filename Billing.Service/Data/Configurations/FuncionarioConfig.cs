using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class FuncionarioConfig : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.EstabelecimentoId)
                    .IsRequired();

            builder.Property(e => e.UsuarioId)
                    .IsRequired();

            builder.HasOne(e => e.Estabelecimento)
                    .WithMany(e => e.Funcionarios)
                    .HasForeignKey(e => e.EstabelecimentoId);

            builder.HasOne(e => e.Usuario)
                    .WithOne(e => e.Funcionario)
                    .HasForeignKey<Funcionario>(e => e.UsuarioId)
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
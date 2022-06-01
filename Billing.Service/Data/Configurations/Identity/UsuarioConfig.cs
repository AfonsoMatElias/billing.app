using System;
using Billing.Service.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            new BaseConfig().Configure(builder);

            builder.ToTable(nameof(Usuario));

            builder.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsRequired();

            builder.Property(e => e.PessoaId);

            builder.Property(e => e.CreatedAt)
                    .HasDefaultValue(DateTime.Now);

            builder.Property(e => e.UpdatedAt);

            builder.Property(e => e.Visibility)
                    .IsRequired();

            builder.HasOne(e => e.Pessoa)
                    .WithOne(e => e.Usuario)
                    .HasForeignKey<Usuario>(e => e.PessoaId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(this.TableSeed());
        }

        internal Usuario[] TableSeed()
        {
            var root = "Admin";
            var rootUpper = root.ToUpper();
            var user = new Usuario
            {
                Id = 1,
                UserName = root,
                NormalizedUserName = rootUpper,
                Email = $"{ root }@{ root }.com",
                NormalizedEmail = $"{ rootUpper }@{ rootUpper }.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
                Codigo = $"{ nameof(Usuario) }{ "1".PadLeft(4, '0') }"
            };

            user.PasswordHash = new PasswordHasher<Usuario>().HashPassword(user, $"{ root }@321");

            return new Usuario[] { user };
        }
    }
}
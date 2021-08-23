using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<long>> builder)
        {
            builder.HasData(
                (new[] {
                    "Admin",
                    "Gestor",
                    "Funcionario",
                    "Vendedor",
                    "Entidade"
                }).Select((item, index) =>
                {
                    return new IdentityRole<long>
                    {
                        Id = (index + 1),
                        Name = item,
                        NormalizedName = item.ToUpper()
                    };
                }).ToArray()
            );
        }
    }
}
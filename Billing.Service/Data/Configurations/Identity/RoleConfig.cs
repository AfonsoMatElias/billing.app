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
                    "Admin:ce23b3ea-8d9a-4992-9ec8-b2d002accc9a",
                    "Gestor:ce23b3ea-8d9a-4992-9ec8-b2d002accc9b",
                    "Funcionario:ce23b3ea-8d9a-4992-9ec8-b2d002accc9c",
                    "Vendedor:ce23b3ea-8d9a-4992-9ec8-b2d002accc9d",
                    "Entidade:ce23b3ea-8d9a-4992-9ec8-b2d002accc9e"
                }).Select((item, index) =>
                {
                    var splitted = item.Split(":");
                    var name = splitted.FirstOrDefault();
                    var concurrencyStamp = splitted.LastOrDefault();

                    return new IdentityRole<long>
                    {
                        Id = (index + 1),
                        Name = name,
                        NormalizedName = name.ToUpper(),
                        ConcurrencyStamp = concurrencyStamp,
                    };
                }).ToArray()
            );
        }
    }
}
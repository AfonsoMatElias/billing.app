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
                    "SuperAdmin:ce23b3ea-8d9a-4992-9ec8-b2d002accc90",
                    "Admin:ce23b3ea-8d9a-4992-9ec8-b2d002accc9a",
                    "Gestor:ce23b3ea-8d9a-4992-9ec8-b2d002accc9b",
                    "Funcionario:ce23b3ea-8d9a-4992-9ec8-b2d002accc9c",
                    "Vendedor:ce23b3ea-8d9a-4992-9ec8-b2d002accc9d",
                    "Fornecedor:ce23b3ea-8d9a-4992-9ec8-b2d002accc9e",
                    "Cliente:ce23b3ea-8d9a-4992-9ec8-b2d002accc9f"
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
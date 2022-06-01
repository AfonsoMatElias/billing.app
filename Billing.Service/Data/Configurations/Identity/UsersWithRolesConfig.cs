using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class UsersWithRolesConfig : IEntityTypeConfiguration<IdentityUserRole<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<long>> builder)
        {
            builder.HasData(
                new IdentityUserRole<long>[] {
                    new IdentityUserRole<long>
                    {
                        RoleId = long.Parse("1"),
                        UserId = long.Parse("1")
                    }
                }
            );
        }
    }
}
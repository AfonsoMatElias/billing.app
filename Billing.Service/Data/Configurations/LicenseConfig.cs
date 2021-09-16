using Billing.Service.Data.Configurations;
using Billing.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class LicenseConfig : IEntityTypeConfiguration<License>
    {
        public void Configure(EntityTypeBuilder<License> builder)
        {
            new BaseConfig().Configure(builder);

            builder.Property(e => e.ApplyDate)
                    .IsRequired();

            builder.Property(e => e.Codigo)
                    .IsRequired();

            builder.Property(e => e.ExpirationDate)
                    .IsRequired();
        }
    }
}
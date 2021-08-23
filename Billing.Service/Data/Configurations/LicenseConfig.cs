using Billing.Service.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Models
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
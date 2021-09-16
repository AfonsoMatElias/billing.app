using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Billing.Service.Data.Configurations
{
    public class BaseConfig
    {
        public void Configure<TModel>(EntityTypeBuilder<TModel> builder) where TModel : class
        {
            builder.HasKey("Id");

            builder.Property("Id").ValueGeneratedOnAdd();

            if (typeof(TModel).GetProperty(nameof(Models.Base.Properties.CreatedAt)) != null)
                builder.Property(nameof(Models.Base.Properties.CreatedAt))
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasDefaultValue(DateTime.Now);

            if (typeof(TModel).GetProperty(nameof(Models.Base.Properties.UpdatedAt)) != null)
                builder.Property(nameof(Models.Base.Properties.UpdatedAt))
                    .HasColumnType("datetime");

            if (typeof(TModel).GetProperty(nameof(Models.Base.Properties.Visibility)) != null)
                builder.Property(nameof(Models.Base.Properties.Visibility))
                    .HasDefaultValue(true)
                    .IsRequired();
        }
    }
}
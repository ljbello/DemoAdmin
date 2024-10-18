using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class HolidayExcludeEmailConfiguration : IEntityTypeConfiguration<HolidayExcludeEmail>
{
    public void Configure(EntityTypeBuilder<HolidayExcludeEmail> entity)
    {
        entity.HasKey(e => new { e.EmailAddress, e.StoreId });

        entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.IsAdded).HasDefaultValue(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<HolidayExcludeEmail> entity);
}

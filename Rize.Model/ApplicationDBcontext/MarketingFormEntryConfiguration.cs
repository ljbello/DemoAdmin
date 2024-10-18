using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MarketingFormEntryConfiguration : IEntityTypeConfiguration<MarketingFormEntry>
{
    public void Configure(EntityTypeBuilder<MarketingFormEntry> entity)
    {
        entity.ToTable("MarketingFormEntry");

        entity.Property(e => e.Address1).HasMaxLength(100);
        entity.Property(e => e.Address2).HasMaxLength(100);
        entity.Property(e => e.City).HasMaxLength(100);
        entity.Property(e => e.CompanyName).HasMaxLength(200);
        entity.Property(e => e.Country).HasMaxLength(50);
        entity.Property(e => e.Email).HasMaxLength(50);
        entity.Property(e => e.FirstName).HasMaxLength(100);
        entity.Property(e => e.LastName).HasMaxLength(100);
        entity.Property(e => e.SourceUrl).HasMaxLength(500);
        entity.Property(e => e.State).HasMaxLength(50);
        entity.Property(e => e.Zip).HasMaxLength(10);

        entity.HasOne(d => d.Store).WithMany(p => p.MarketingFormEntries)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarketingFormEntry_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MarketingFormEntry> entity);
}

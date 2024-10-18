using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CouponTrackerConfiguration : IEntityTypeConfiguration<CouponTracker>
{
    public void Configure(EntityTypeBuilder<CouponTracker> entity)
    {
        entity.ToTable("CouponTracker");

        entity.Property(e => e.CouponTrackerId).HasColumnName("CouponTrackerID");
        entity.Property(e => e.CouponCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Isactive).HasColumnName("ISActive");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CouponTracker> entity);
}

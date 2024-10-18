using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CouponTrackerOrderConfiguration : IEntityTypeConfiguration<CouponTrackerOrder>
{
    public void Configure(EntityTypeBuilder<CouponTrackerOrder> entity)
    {
        entity.ToTable("CouponTrackerOrder");

        entity.Property(e => e.CouponTrackerOrderId).HasColumnName("CouponTrackerOrderID");
        entity.Property(e => e.CouponTrackerId).HasColumnName("CouponTrackerID");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OrderId).HasColumnName("OrderID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CouponTrackerOrder> entity);
}

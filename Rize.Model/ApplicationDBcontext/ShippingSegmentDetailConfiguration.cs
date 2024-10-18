using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingSegmentDetailConfiguration : IEntityTypeConfiguration<ShippingSegmentDetail>
{
    public void Configure(EntityTypeBuilder<ShippingSegmentDetail> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Shipping__3214EC07495D8B06");

        entity.ToTable("ShippingSegmentDetail");

        entity.HasIndex(e => new { e.SegmentId, e.Low, e.High, e.CreatedOn, e.Active }, "ShippingSegmentDetail_IX1");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Rate).HasColumnType("money");

        entity.HasOne(d => d.Segment).WithMany(p => p.ShippingSegmentDetails)
                .HasForeignKey(d => d.SegmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingSegmentDetail_ShippingSegment");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingSegmentDetail> entity);
}

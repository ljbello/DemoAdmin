using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingGroupSegmentMethodConfiguration : IEntityTypeConfiguration<ShippingGroupSegmentMethod>
{
    public void Configure(EntityTypeBuilder<ShippingGroupSegmentMethod> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Shipping__3214EC071F36A2C7");

        entity.ToTable("ShippingGroupSegmentMethod");

        entity.HasIndex(e => new { e.GroupId, e.MethodId, e.SegmentId }, "ShippingGroupSegmentMethod_IX1");

        entity.Property(e => e.CreatedBy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.Group).WithMany(p => p.ShippingGroupSegmentMethods)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingGroupSegmentMethod_ShippingGroup");

        entity.HasOne(d => d.Segment).WithMany(p => p.ShippingGroupSegmentMethods)
                .HasForeignKey(d => d.SegmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingGroupSegmentMethod_ShippingSegment");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingGroupSegmentMethod> entity);
}

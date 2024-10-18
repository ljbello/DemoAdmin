using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ShippingSegmentConfiguration : IEntityTypeConfiguration<ShippingSegment>
{
    public void Configure(EntityTypeBuilder<ShippingSegment> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Shipping__3214EC074900FB9B");

        entity.ToTable("ShippingSegment");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ShippingSegmentCreatedByNavigations).HasForeignKey(d => d.CreatedBy);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ShippingSegmentModifiedByNavigations).HasForeignKey(d => d.ModifiedBy);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ShippingSegment> entity);
}

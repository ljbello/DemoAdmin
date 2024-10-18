using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DiscountGroupQuantityConfiguration : IEntityTypeConfiguration<DiscountGroupQuantity>
{
    public void Configure(EntityTypeBuilder<DiscountGroupQuantity> entity)
    {
        entity.ToTable("DiscountGroupQuantity");

        entity.HasIndex(e => e.DiscountGroupId, "DiscountGroupQuantity_IX1");

        entity.Property(e => e.DiscountGroupQuantityId).HasColumnName("DiscountGroupQuantityID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.DiscountAmount).HasColumnType("money");
        entity.Property(e => e.DiscountGroupId).HasColumnName("DiscountGroupID");

        entity.HasOne(d => d.DiscountGroup).WithMany(p => p.DiscountGroupQuantities)
                .HasForeignKey(d => d.DiscountGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountGroupQuantity_DiscountGroup");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DiscountGroupQuantity> entity);
}

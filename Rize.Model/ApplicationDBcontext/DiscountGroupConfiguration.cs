using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DiscountGroupConfiguration : IEntityTypeConfiguration<DiscountGroup>
{
    public void Configure(EntityTypeBuilder<DiscountGroup> entity)
    {
        entity.ToTable("DiscountGroup");

        entity.Property(e => e.DiscountGroupId).HasColumnName("DiscountGroupID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Description).HasMaxLength(800);
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DiscountGroups)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountGroup_tblUsers");

        entity.HasOne(d => d.Store).WithMany(p => p.DiscountGroups)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountGroup_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DiscountGroup> entity);
}

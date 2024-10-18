using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblPricingGroupConfiguration : IEntityTypeConfiguration<TblPricingGroup>
{
    public void Configure(EntityTypeBuilder<TblPricingGroup> entity)
    {
        entity.HasKey(e => new { e.PriGroPricingGroupId, e.StoreId });

        entity.ToTable("tblPricingGroups");

        entity.Property(e => e.PriGroPricingGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PriGro__PricingGroupID");
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");
        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.PriGroPricingGroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PriGro__PricingGroup");
        entity.Property(e => e.PriGroPricingGroupAbrev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PriGro__PricingGroup_Abrev");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblPricingGroups)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblPricingGroups_tblUsers");

        entity.HasOne(d => d.Store).WithMany(p => p.TblPricingGroups)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPricingGroups_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblPricingGroup> entity);
}

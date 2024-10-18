using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VariationPricingGroupConfiguration : IEntityTypeConfiguration<VariationPricingGroup>
{
    public void Configure(EntityTypeBuilder<VariationPricingGroup> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Variatio__3214EC27DA6CED68");

        entity.ToTable("VariationPricingGroup");

        entity.HasIndex(e => e.Active, "VariationPricingGroup_IX1");

        entity.HasIndex(e => new { e.StoreId, e.IsDefault, e.Active }, "VariationPricingGroup_IX2");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Description)
                .HasMaxLength(2048)
                .IsUnicode(false);
        entity.Property(e => e.IsDefault).HasDefaultValue(true);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.VariationPricingGroupCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroup_tblUser");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.VariationPricingGroupModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_VariationPricingGroup_tblUser1");

        entity.HasOne(d => d.ProductType).WithMany(p => p.VariationPricingGroups)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroup_ProductType");

        entity.HasOne(d => d.Store).WithMany(p => p.VariationPricingGroups)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroup_tblStore");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VariationPricingGroup> entity);
}

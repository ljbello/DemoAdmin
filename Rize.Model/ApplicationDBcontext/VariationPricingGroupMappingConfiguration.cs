using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VariationPricingGroupMappingConfiguration : IEntityTypeConfiguration<VariationPricingGroupMapping>
{
    public void Configure(EntityTypeBuilder<VariationPricingGroupMapping> entity)
    {
        entity.HasKey(e => e.MappingId);

        entity.ToTable("VariationPricingGroupMapping");

        entity.Property(e => e.MappingId).HasColumnName("MappingID");
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.HolidayCard).HasDefaultValue(false);
        entity.Property(e => e.InsertDatetime).HasColumnType("datetime");
        entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
        entity.Property(e => e.ProductvariationId).HasColumnName("ProductvariationID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.SupplierPricinggroupId).HasColumnName("SupplierPricinggroupID");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.VariationPricingGroupMappings)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroupMapping_tblUsers");

        entity.HasOne(d => d.ProductType).WithMany(p => p.VariationPricingGroupMappings)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK_VariationPricingGroupMapping_ProductType");

        entity.HasOne(d => d.Productvariation).WithMany(p => p.VariationPricingGroupMappings)
                .HasForeignKey(d => d.ProductvariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroupMapping_ProductVariation");

        entity.HasOne(d => d.SupplierPricinggroup).WithMany(p => p.VariationPricingGroupMappings)
                .HasForeignKey(d => d.SupplierPricinggroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VariationPricingGroupMapping_tblSupplierPricing");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VariationPricingGroupMapping> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierEnvelopesPricingVersionConfiguration : IEntityTypeConfiguration<TblSupplierEnvelopesPricingVersion>
{
    public void Configure(EntityTypeBuilder<TblSupplierEnvelopesPricingVersion> entity)
    {
        entity.HasKey(e => new { e.SupplierEnvelopeId, e.CreatedOn, e.StoreId }).HasName("PK_SupplierEnvelopes_PricingVersions");

        entity.ToTable("tblSupplierEnvelopes_PricingVersions");

        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");
        entity.Property(e => e.DpproductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DPProductOptionPriceGroupId");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblSupplierEnvelopesPricingVersions)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_SupplierEnvelopes_PricingVersions_UserModified");

        entity.HasOne(d => d.Store).WithMany(p => p.TblSupplierEnvelopesPricingVersions)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierEnvelopes_PricingVersions_Store");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierEnvelopesPricingVersion> entity);
}

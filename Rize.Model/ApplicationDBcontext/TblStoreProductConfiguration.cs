using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreProductConfiguration : IEntityTypeConfiguration<TblStoreProduct>
{
    public void Configure(EntityTypeBuilder<TblStoreProduct> entity)
    {
        entity.HasKey(e => new { e.StoStoreId, e.ProProductId }).HasName("tblStoreProducts_PK");

        entity.ToTable("tblStoreProducts", tb =>
                {
                    tb.HasTrigger("DisplayOffsetChanged");
                    tb.HasTrigger("tblstoreproducts_Update");
                });

        entity.HasIndex(e => new { e.StoStoreId, e.ProStaProductStatusId, e.ProProductId }, "IX_tblStoreProducts_IX4");

        entity.HasIndex(e => new { e.ProProductId, e.StoStoreId }, "tblStoreProducts_IX1");

        entity.HasIndex(e => new { e.StoStoreId, e.StoProName }, "tblStoreProducts_IX2");

        entity.HasIndex(e => new { e.StoStoreId, e.ActiveDate }, "tblStoreProducts_IX3");

        entity.HasIndex(e => e.PriGroPricingGroupId, "tblStoreProducts_IX4");

        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.ActiveDate).HasColumnType("datetime");
        entity.Property(e => e.DepDepartmentIdDefault).HasColumnName("Dep__DepartmentID_Default");
        entity.Property(e => e.DisplayOffsetUpdatedDate).HasColumnType("datetime");
        entity.Property(e => e.MerchandisingDate).HasColumnType("datetime");
        entity.Property(e => e.MetaDescription)
                .HasMaxLength(290)
                .IsUnicode(false);
        entity.Property(e => e.PriGroPricingGroupId).HasColumnName("PriGro__PricingGroupID");
        entity.Property(e => e.ProStaProductStatusId).HasColumnName("ProSta__ProductStatusID");
        entity.Property(e => e.StarCount).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.StoProDescription)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("StoPro__Description");
        entity.Property(e => e.StoProDisplayOffset).HasColumnName("StoPro__DisplayOffset");
        entity.Property(e => e.StoProName)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("StoPro__Name");
        entity.Property(e => e.StoProNumberOfSales).HasColumnName("StoPro__NumberOfSales");
        entity.Property(e => e.StoProPageTitle)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("StoPro__PageTitle");
        entity.Property(e => e.StoProRedirectUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("StoPro__RedirectUrl");

        entity.HasOne(d => d.ProProduct).WithMany(p => p.TblStoreProducts)
                .HasForeignKey(d => d.ProProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreProducts_tblProducts");

        entity.HasOne(d => d.ProStaProductStatus).WithMany(p => p.TblStoreProducts)
                .HasForeignKey(d => d.ProStaProductStatusId)
                .HasConstraintName("FK_tblStoreProducts_tblProductStatuses");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblStoreProducts)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreProducts_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreProduct> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreProductsBakConfiguration : IEntityTypeConfiguration<TblStoreProductsBak>
{
    public void Configure(EntityTypeBuilder<TblStoreProductsBak> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblStoreProductsBak");

        entity.Property(e => e.ActiveDate).HasColumnType("datetime");
        entity.Property(e => e.DepDepartmentIdDefault).HasColumnName("Dep__DepartmentID_Default");
        entity.Property(e => e.DisplayOffsetUpdatedDate).HasColumnType("datetime");
        entity.Property(e => e.MerchandisingDate).HasColumnType("datetime");
        entity.Property(e => e.MetaDescription)
                .HasMaxLength(290)
                .IsUnicode(false);
        entity.Property(e => e.PriGroPricingGroupId).HasColumnName("PriGro__PricingGroupID");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
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
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreProductsBak> entity);
}

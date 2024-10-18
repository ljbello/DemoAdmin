using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreDepartmentCategoryConfiguration : IEntityTypeConfiguration<TblStoreDepartmentCategory>
{
    public void Configure(EntityTypeBuilder<TblStoreDepartmentCategory> entity)
    {
        entity.HasKey(e => new { e.StoStoreId, e.DepDepartmentId });

        entity.ToTable("tblStoreDepartmentCategory");

        entity.HasIndex(e => new { e.StoStoreId, e.DepDepartmentId }, "tblStoreDepartmentcategory_IX1");

        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreId");
        entity.Property(e => e.DepDepartmentId).HasColumnName("Dep__DepartmentId");
        entity.Property(e => e.HeaderMetaTags).HasMaxLength(500);
        entity.Property(e => e.StoDepCatAlwaysShow).HasColumnName("StoDepCat__AlwaysShow");
        entity.Property(e => e.StoDepCatBanner).HasColumnName("StoDepCat__Banner");
        entity.Property(e => e.StoDepCatBannerPages)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__BannerPages");
        entity.Property(e => e.StoDepCatBodyBoxTitle)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__BodyBoxTitle");
        entity.Property(e => e.StoDepCatCardTotalLine)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__CardTotalLine");
        entity.Property(e => e.StoDepCatLinkTitle)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__LinkTitle");
        entity.Property(e => e.StoDepCatPaginationLinkTitle)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__PaginationLinkTitle");
        entity.Property(e => e.StoDepCatPrimaryKeyword)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__PrimaryKeyword");
        entity.Property(e => e.StoDepCatTagline)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__Tagline");
        entity.Property(e => e.StoDepCatTitle)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("StoDepCat__Title");

        entity.HasOne(d => d.DepDepartment).WithMany(p => p.TblStoreDepartmentCategories)
                .HasForeignKey(d => d.DepDepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreDepartmentCategory_tblDepartments");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblStoreDepartmentCategories)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreDepartmentCategory_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreDepartmentCategory> entity);
}

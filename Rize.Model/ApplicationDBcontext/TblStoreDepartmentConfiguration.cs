using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreDepartmentConfiguration : IEntityTypeConfiguration<TblStoreDepartment>
{
    public void Configure(EntityTypeBuilder<TblStoreDepartment> entity)
    {
        entity.HasKey(e => new { e.StoStoreId, e.DepDepartmentId }).HasName("tblStoreDepartments_PK");

        entity.ToTable("tblStoreDepartments");

        entity.HasIndex(e => new { e.StoStoreId, e.StoDepPagePageName }, "IX_StoDep__Page_PageName");

        entity.HasIndex(e => e.StoDepPagePageName, "index_48");

        entity.HasIndex(e => e.DepDepartmentId, "tblStoreDepartments_IX1");

        entity.HasIndex(e => new { e.StoStoreId, e.DepDepartmentId }, "tblStoreDepartments_IX2");

        entity.HasIndex(e => new { e.StoStoreId, e.StoDepActive, e.StoDepNavDestinationTypeId }, "tblStoreDepartments_IX3");

        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.DepDepartmentId).HasColumnName("Dep__DepartmentID");
        entity.Property(e => e.StoDepActive)
                .HasDefaultValue(true)
                .HasColumnName("StoDep__Active");
        entity.Property(e => e.StoDepName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDep__Name");
        entity.Property(e => e.StoDepNavDestinationTypeId)
                .HasDefaultValue(1)
                .HasColumnName("StoDep__NavDestinationTypeID");
        entity.Property(e => e.StoDepPageBottomTag)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_Bottom_Tag");
        entity.Property(e => e.StoDepPageHeaderText)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_HeaderText");
        entity.Property(e => e.StoDepPageHeaderText2)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_HeaderText2");
        entity.Property(e => e.StoDepPageHolidayBarStyle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_HolidayBarStyle");
        entity.Property(e => e.StoDepPageLogoText)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_LogoText");
        entity.Property(e => e.StoDepPageMarketingDescription).HasColumnName("StoDep__Page_MarketingDescription");
        entity.Property(e => e.StoDepPageMarketingDescription2).HasColumnName("StoDep__Page_MarketingDescription2");
        entity.Property(e => e.StoDepPageMetaTagDescription)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_MetaTag_Description");
        entity.Property(e => e.StoDepPageMetaTagKeywords)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_MetaTag_Keywords");
        entity.Property(e => e.StoDepPagePageName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_PageName");
        entity.Property(e => e.StoDepPageTitle)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_Title");
        entity.Property(e => e.StoDepPageTopTag)
                .HasMaxLength(768)
                .IsUnicode(false)
                .HasColumnName("StoDep__Page_Top_Tag");
        entity.Property(e => e.StoDepPrimaryDirectoryPath)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("StoDep__PrimaryDirectoryPath");
        entity.Property(e => e.StoDepUseDepartmentRank).HasColumnName("StoDep__UseDepartmentRank");

        entity.HasOne(d => d.DepDepartment).WithMany(p => p.TblStoreDepartments)
                .HasForeignKey(d => d.DepDepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreDepartments_tblDepartments");

        entity.HasOne(d => d.StoDepNavDestinationType).WithMany(p => p.TblStoreDepartments)
                .HasForeignKey(d => d.StoDepNavDestinationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreDepartments_NavDestinationType");

        entity.HasOne(d => d.StoStore).WithMany(p => p.TblStoreDepartments)
                .HasForeignKey(d => d.StoStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblStoreDepartments_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreDepartment> entity);
}

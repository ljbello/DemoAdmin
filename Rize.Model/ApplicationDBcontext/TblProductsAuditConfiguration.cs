using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductsAuditConfiguration : IEntityTypeConfiguration<TblProductsAudit>
{
    public void Configure(EntityTypeBuilder<TblProductsAudit> entity)
    {
        entity.HasKey(e => e.ProAudProductAuditId);

        entity.ToTable("tblProducts_Audit");

        entity.Property(e => e.ProAudProductAuditId).HasColumnName("Pro_Aud__ProductAuditID");
        entity.Property(e => e.ProAudLastUpdatedByUserId).HasColumnName("Pro_Aud__LastUpdatedByUserID");
        entity.Property(e => e.ProAudLastUpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Pro_Aud__LastUpdatedDate");
        entity.Property(e => e.ProAudProductStatusIdnew).HasColumnName("Pro_Aud__ProductStatusIDNew");
        entity.Property(e => e.ProAudProductStatusIdold).HasColumnName("Pro_Aud__ProductStatusIDOld");
        entity.Property(e => e.ProAudSupplierIdnew).HasColumnName("Pro_Aud__SupplierIDNew");
        entity.Property(e => e.ProAudSupplierIdold).HasColumnName("Pro_Aud__SupplierIDOld");
        entity.Property(e => e.ProAudSupplierProductNumberNew)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro_Aud__SupplierProductNumberNew");
        entity.Property(e => e.ProAudSupplierProductNumberOld)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro_Aud__SupplierProductNumberOld");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductsAudit> entity);
}

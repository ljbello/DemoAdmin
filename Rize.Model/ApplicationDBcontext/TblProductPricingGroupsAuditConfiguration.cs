using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblProductPricingGroupsAuditConfiguration : IEntityTypeConfiguration<TblProductPricingGroupsAudit>
{
    public void Configure(EntityTypeBuilder<TblProductPricingGroupsAudit> entity)
    {
        entity.HasKey(e => e.ProPriGroAudProductPricingGroupAuditId);

        entity.ToTable("tblProductPricingGroups_Audit");

        entity.Property(e => e.ProPriGroAudProductPricingGroupAuditId).HasColumnName("ProPriGro_Aud__ProductPricingGroupAuditID");
        entity.Property(e => e.ProPriGroAudLastUpdatedByUserId).HasColumnName("ProPriGro_Aud__LastUpdatedByUserID");
        entity.Property(e => e.ProPriGroAudLastUpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ProPriGro_Aud__LastUpdatedDate");
        entity.Property(e => e.ProPriGroAudPricingGroupIdnew).HasColumnName("ProPriGro_Aud__PricingGroupIDNew");
        entity.Property(e => e.ProPriGroAudPricingGroupIdold).HasColumnName("ProPriGro_Aud__PricingGroupIDOld");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblProductPricingGroupsAudit> entity);
}

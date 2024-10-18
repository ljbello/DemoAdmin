using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreSupplierRetailDiscountsAuditConfiguration : IEntityTypeConfiguration<TblStoreSupplierRetailDiscountsAudit>
{
    public void Configure(EntityTypeBuilder<TblStoreSupplierRetailDiscountsAudit> entity)
    {
        entity.ToTable("tblStoreSupplierRetailDiscounts_Audit");

        entity.Property(e => e.TblStoreSupplierRetailDiscountsAuditId).HasColumnName("tblStoreSupplierRetailDiscounts_AuditID");
        entity.Property(e => e.AuditTimeStamp).HasColumnType("datetime");
        entity.Property(e => e.PricingGroupIdNew).HasColumnName("PricingGroupID_New");
        entity.Property(e => e.PricingGroupIdOld).HasColumnName("PricingGroupID_Old");
        entity.Property(e => e.StoreSupplierRetailDiscountId).HasColumnName("StoreSupplierRetailDiscountID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreSupplierRetailDiscountsAudit> entity);
}

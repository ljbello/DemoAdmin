using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TmpProductsStockRequestConfiguration : IEntityTypeConfiguration<TmpProductsStockRequest>
{
    public void Configure(EntityTypeBuilder<TmpProductsStockRequest> entity)
    {
        entity.HasKey(e => new { e.SessionGuid, e.ProSupplierProductNumber }).HasName("PK_tmpProductsStockRequests_1");

        entity.ToTable("tmpProductsStockRequests");

        entity.Property(e => e.ProSupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__SupplierProductNumber");
        entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TmpProductsStockRequest> entity);
}

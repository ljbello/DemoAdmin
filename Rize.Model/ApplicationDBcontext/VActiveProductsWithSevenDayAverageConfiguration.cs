using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VActiveProductsWithSevenDayAverageConfiguration : IEntityTypeConfiguration<VActiveProductsWithSevenDayAverage>
{
    public void Configure(EntityTypeBuilder<VActiveProductsWithSevenDayAverage> entity)
    {
        entity
                .HasNoKey()
                .ToView("vActiveProductsWithSevenDayAverage");

        entity.Property(e => e.PreviousSevenDayAverage).HasColumnType("decimal(18, 3)");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.ProSampleOnOrderDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Pro__SampleOnOrder_Date");
        entity.Property(e => e.ProStaProductStatusId).HasColumnName("ProSta__ProductStatusID");
        entity.Property(e => e.ProSupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Pro__SupplierProductNumber");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VActiveProductsWithSevenDayAverage> entity);
}

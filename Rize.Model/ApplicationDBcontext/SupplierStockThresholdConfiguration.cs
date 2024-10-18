using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierStockThresholdConfiguration : IEntityTypeConfiguration<SupplierStockThreshold>
{
    public void Configure(EntityTypeBuilder<SupplierStockThreshold> entity)
    {
        entity.ToTable("SupplierStockThreshold");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SupplierStockThresholds)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierStockThreshold_tblUser");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierStockThreshold> entity);
}

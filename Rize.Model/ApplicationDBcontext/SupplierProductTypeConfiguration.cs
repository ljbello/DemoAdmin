using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierProductTypeConfiguration : IEntityTypeConfiguration<SupplierProductType>
{
    public void Configure(EntityTypeBuilder<SupplierProductType> entity)
    {
        entity.ToTable("SupplierProductType");

        entity.HasIndex(e => new { e.ProductTypeId, e.SupplierId }, "SupplierProductType_IX1");

        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.ProductionHours).HasDefaultValue((short)24);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SupplierProductTypes)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_SupplierProductType_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierProductType> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DeliveryEstimationCategoryElementBySupplierConfiguration : IEntityTypeConfiguration<DeliveryEstimationCategoryElementBySupplier>
{
    public void Configure(EntityTypeBuilder<DeliveryEstimationCategoryElementBySupplier> entity)
    {
        entity.ToTable("DeliveryEstimationCategoryElementBySupplier");

        entity.HasIndex(e => new { e.DeliveryEstimationCategoryElementId, e.SupplierId }, "DeliveryEstimationCategoryElementBySupplier_IX1").IsUnique();

        entity.Property(e => e.DeliveryEstimationCategoryElementBySupplierId).HasColumnName("DeliveryEstimationCategoryElementBySupplierID");
        entity.Property(e => e.DeliveryEstimationCategoryElementId).HasColumnName("DeliveryEstimationCategoryElementID");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Status).HasDefaultValue(true);
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        entity.HasOne(d => d.DeliveryEstimationCategoryElement).WithMany(p => p.DeliveryEstimationCategoryElementBySuppliers)
                .HasForeignKey(d => d.DeliveryEstimationCategoryElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryEstimationCategoryElementBySupplier_DeliveryEstimationCategoryElement");

        entity.HasOne(d => d.Supplier).WithMany(p => p.DeliveryEstimationCategoryElementBySuppliers)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryEstimationCategoryElementBySupplier_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DeliveryEstimationCategoryElementBySupplier> entity);
}

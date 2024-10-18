using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DeliveryEstimationSupplierClosureConfiguration : IEntityTypeConfiguration<DeliveryEstimationSupplierClosure>
{
    public void Configure(EntityTypeBuilder<DeliveryEstimationSupplierClosure> entity)
    {
        entity.ToTable("DeliveryEstimationSupplierClosure");

        entity.HasIndex(e => e.ClosureDate, "DeliveryEstimationSupplierClosure_IX1");

        entity.HasIndex(e => new { e.SupplierId, e.ClosureDate, e.Status }, "IX_DeliveryEstimationSupplierClosure_SupplierID_ClosureDate_Status");

        entity.Property(e => e.DeliveryEstimationSupplierClosureId).HasColumnName("DeliveryEstimationSupplierClosureID");
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Note)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Status).HasDefaultValue(true);
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        entity.HasOne(d => d.Supplier).WithMany(p => p.DeliveryEstimationSupplierClosures)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryEstimationSupplierClosure_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DeliveryEstimationSupplierClosure> entity);
}

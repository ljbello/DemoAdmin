using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationFoilDieConfiguration : IEntityTypeConfiguration<SupplierAllocationFoilDie>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationFoilDie> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Supplier__3214EC072BD6E65A");

        entity.ToTable("SupplierAllocationFoilDie");

        entity.HasIndex(e => new { e.SupplierId, e.FoilDieCode }, "IX_SupplierAllocationFoilDie_SupplierId_FoilDieCode").IsUnique();

        entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");
        entity.Property(e => e.FoilDieCode).HasMaxLength(50);

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierAllocationFoilDies)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierAllocationFoilDie_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationFoilDie> entity);
}

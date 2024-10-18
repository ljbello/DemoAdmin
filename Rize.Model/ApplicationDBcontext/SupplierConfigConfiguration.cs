using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierConfigConfiguration : IEntityTypeConfiguration<SupplierConfig>
{
    public void Configure(EntityTypeBuilder<SupplierConfig> entity)
    {
        entity.ToTable("SupplierConfig");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Key).HasMaxLength(50);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Value).HasMaxLength(255);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SupplierConfigCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.SupplierConfigModifiedByNavigations).HasForeignKey(d => d.ModifiedBy);

        entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierConfigs)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierConfig_tblSuppliers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierConfig> entity);
}

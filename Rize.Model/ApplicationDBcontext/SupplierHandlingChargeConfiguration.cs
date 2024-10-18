using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierHandlingChargeConfiguration : IEntityTypeConfiguration<SupplierHandlingCharge>
{
    public void Configure(EntityTypeBuilder<SupplierHandlingCharge> entity)
    {
        entity.ToTable("SupplierHandlingCharge");

        entity.HasIndex(e => new { e.SupplierId, e.EffectiveDate }, "IX_SupplierHandlingCharge").IsUnique();

        entity.Property(e => e.SupplierHandlingChargeId).HasColumnName("SupplierHandlingChargeID");
        entity.Property(e => e.AmountCharged).HasColumnType("money");
        entity.Property(e => e.Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierHandlingCharge> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PricingFormulaConfiguration : IEntityTypeConfiguration<PricingFormula>
{
    public void Configure(EntityTypeBuilder<PricingFormula> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__PricingF__3214EC07A0E9C335");

        entity.ToTable("PricingFormula");

        entity.HasIndex(e => new { e.KeyCode, e.StoreId }, "PricingFormula_IX1");

        entity.Property(e => e.Description)
                .HasMaxLength(800)
                .IsUnicode(false);
        entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.KeyCode)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Rounding).HasColumnType("decimal(18, 2)");
        entity.Property(e => e.SetupCharge).HasColumnType("money");
        entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PricingFormula> entity);
}

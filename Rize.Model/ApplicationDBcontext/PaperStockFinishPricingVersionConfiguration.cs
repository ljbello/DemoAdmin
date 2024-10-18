using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PaperStockFinishPricingVersionConfiguration : IEntityTypeConfiguration<PaperStockFinishPricingVersion>
{
    public void Configure(EntityTypeBuilder<PaperStockFinishPricingVersion> entity)
    {
        entity.HasKey(e => new { e.PaperStockFinishId, e.CreatedOn, e.StoreId });

        entity.ToTable("PaperStockFinish_PricingVersions");

        entity.HasIndex(e => new { e.StoreId, e.PaperStockFinishId, e.CreatedOn }, "PaperStockFinish_PricingVersions_IX1");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");
        entity.Property(e => e.DpproductOptionPriceGroupId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DPProductOptionPriceGroupId");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PaperStockFinishPricingVersions)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_PaperStockFinish_PricingVersions_UserModified");

        entity.HasOne(d => d.Store).WithMany(p => p.PaperStockFinishPricingVersions)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaperStockFinish_PricingVersions_Store");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PaperStockFinishPricingVersion> entity);
}

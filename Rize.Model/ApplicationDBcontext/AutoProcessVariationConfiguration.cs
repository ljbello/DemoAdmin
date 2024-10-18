using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AutoProcessVariationConfiguration : IEntityTypeConfiguration<AutoProcessVariation>
{
    public void Configure(EntityTypeBuilder<AutoProcessVariation> entity)
    {
        entity.HasKey(e => new { e.VariationId, e.StoreId });

        entity.ToTable("AutoProcessVariation");

        entity.HasIndex(e => new { e.VariationId, e.StoreId, e.Active }, "AutoProcessVariation_IX1");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        entity.HasOne(d => d.Store).WithMany(p => p.AutoProcessVariations)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutoProcessVariation_tblStores");

        entity.HasOne(d => d.Variation).WithMany(p => p.AutoProcessVariations)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutoProcessVariation_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AutoProcessVariation> entity);
}

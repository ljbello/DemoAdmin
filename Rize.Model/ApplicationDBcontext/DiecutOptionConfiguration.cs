using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DiecutOptionConfiguration : IEntityTypeConfiguration<DiecutOption>
{
    public void Configure(EntityTypeBuilder<DiecutOption> entity)
    {
        entity.HasKey(e => e.DieCutId).HasName("PK__DiecutOp__CA95FA6FBBA6A0EA");

        entity.ToTable("DiecutOption");

        entity.Property(e => e.AreaMode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DieCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DisplayImage)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.Variation).WithMany(p => p.DiecutOptions)
                .HasForeignKey(d => d.VariationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiecutOption_ProductVariation");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DiecutOption> entity);
}

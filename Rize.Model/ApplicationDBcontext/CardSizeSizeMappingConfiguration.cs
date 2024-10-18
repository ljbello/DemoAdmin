using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CardSizeSizeMappingConfiguration : IEntityTypeConfiguration<CardSizeSizeMapping>
{
    public void Configure(EntityTypeBuilder<CardSizeSizeMapping> entity)
    {
        entity.ToTable("CardSizeSizeMapping");

        entity.HasOne(d => d.CardSize).WithMany(p => p.CardSizeSizeMappings)
                .HasForeignKey(d => d.CardSizeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CardSizeSizeMapping_CardSize");

        entity.HasOne(d => d.Size).WithMany(p => p.CardSizeSizeMappings)
                .HasForeignKey(d => d.SizeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CardSizeSizeMapping_tblSizes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CardSizeSizeMapping> entity);
}

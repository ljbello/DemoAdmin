using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CardSizeConfiguration : IEntityTypeConfiguration<CardSize>
{
    public void Configure(EntityTypeBuilder<CardSize> entity)
    {
        entity.ToTable("CardSize");

        entity.Property(e => e.IsPv2).HasColumnName("IsPV2");
        entity.Property(e => e.IsPv3).HasColumnName("IsPV3");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.ProductVariation).WithMany(p => p.CardSizes)
                .HasForeignKey(d => d.ProductVariationId)
                .HasConstraintName("FK_CardSize_ProductVariation1");

        entity.HasOne(d => d.Size).WithMany(p => p.CardSizes)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_CardSize_tblSizes");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CardSize> entity);
}

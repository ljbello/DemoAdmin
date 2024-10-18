using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class RotatorFeatureConfiguration : IEntityTypeConfiguration<RotatorFeature>
{
    public void Configure(EntityTypeBuilder<RotatorFeature> entity)
    {
        entity.ToTable("RotatorFeature");

        entity.HasIndex(e => e.StoreId, "RotatorFeature_IX_StoreID");

        entity.Property(e => e.RotatorFeatureId).HasColumnName("RotatorFeatureID");
        entity.Property(e => e.HtmlContent).IsUnicode(false);
        entity.Property(e => e.Image)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.Link)
                .HasMaxLength(300)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.StoreId)
                .HasDefaultValue(1)
                .HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<RotatorFeature> entity);
}

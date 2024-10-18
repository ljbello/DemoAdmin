using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PersonalizationLayoutImportConfiguration : IEntityTypeConfiguration<PersonalizationLayoutImport>
{
    public void Configure(EntityTypeBuilder<PersonalizationLayoutImport> entity)
    {
        entity
                .HasNoKey()
                .ToTable("PersonalizationLayoutImport");

        entity.Property(e => e.AreaMode).HasMaxLength(255);
        entity.Property(e => e.AreaName).HasMaxLength(255);
        entity.Property(e => e.AreaType).HasMaxLength(255);
        entity.Property(e => e.Artwork).HasMaxLength(255);
        entity.Property(e => e.ArtworkMaskName)
                .HasMaxLength(255)
                .HasColumnName("Artwork Mask Name");
        entity.Property(e => e.ArtworkName).HasMaxLength(250);
        entity.Property(e => e.DefaultLayoutForThisSection).HasColumnName("Default Layout For this Section");
        entity.Property(e => e.DefaultSectionForThisVariation).HasColumnName("Default Section For this Variation");
        entity.Property(e => e.DividerImage).HasMaxLength(255);
        entity.Property(e => e.DtaLeft).HasColumnName("Dta Left");
        entity.Property(e => e.DtaTop).HasColumnName("Dta Top");
        entity.Property(e => e.HorizontalAlignment).HasMaxLength(255);
        entity.Property(e => e.LayoutGroup)
                .HasMaxLength(255)
                .HasColumnName("Layout Group");
        entity.Property(e => e.LayoutIcon).HasColumnName("Layout Icon");
        entity.Property(e => e.Orientation)
                .HasMaxLength(255)
                .HasColumnName("orientation");
        entity.Property(e => e.PaperStockImage).HasMaxLength(255);
        entity.Property(e => e.PlateAnchor).HasMaxLength(255);
        entity.Property(e => e.PreviewGroup).HasMaxLength(255);
        entity.Property(e => e.PriceId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PriceID");
        entity.Property(e => e.ProductVariation)
                .HasMaxLength(255)
                .HasColumnName("Product Variation");
        entity.Property(e => e.Section).HasMaxLength(255);
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.VerticalAlignment).HasMaxLength(255);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PersonalizationLayoutImport> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationConfiguration : IEntityTypeConfiguration<ProductVariation>
{
    public void Configure(EntityTypeBuilder<ProductVariation> entity)
    {
        entity.ToTable("ProductVariation");

        entity.HasIndex(e => e.Name, "Productvariation_IX1");

        entity.HasIndex(e => new { e.Width, e.Height }, "_dta_index_ProductVariation_7_2102376096__K4_K3");

        entity.Property(e => e.AllowAddressing).HasDefaultValue(false);
        entity.Property(e => e.AllowAop)
                .HasDefaultValue(true)
                .HasColumnName("AllowAOP");
        entity.Property(e => e.AllowMailing).HasDefaultValue(false);
        entity.Property(e => e.AllowTemplateOptions).HasDefaultValue(true);
        entity.Property(e => e.Description).HasMaxLength(800);
        entity.Property(e => e.Dimensions)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Disclaimer).HasMaxLength(800);
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Format)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.FriendlyName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.IsCircular).HasDefaultValue(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PlateColorSpace).HasDefaultValue((byte)1);
        entity.Property(e => e.PlateResolution).HasDefaultValue(300);
        entity.Property(e => e.PlateType)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.Preconverted).HasDefaultValue(false);
        entity.Property(e => e.PrinterCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ScaleDpi).HasColumnName("ScaleDPI");
        entity.Property(e => e.ShortName)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.ShowBackTemplate).HasDefaultValue(true);
        entity.Property(e => e.ShowFrontTemplate).HasDefaultValue(true);
        entity.Property(e => e.ShowPrintSafe).HasDefaultValue(true);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariation> entity);
}

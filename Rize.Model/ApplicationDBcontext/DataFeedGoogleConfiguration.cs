using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DataFeedGoogleConfiguration : IEntityTypeConfiguration<DataFeedGoogle>
{
    public void Configure(EntityTypeBuilder<DataFeedGoogle> entity)
    {
        entity
                .HasNoKey()
                .ToTable("DataFeedGoogle");

        entity.Property(e => e.AdditionalImageLinks)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("additional_image_links");
        entity.Property(e => e.Availability)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("availability");
        entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("brand");
        entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Condition)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("condition");
        entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("description");
        entity.Property(e => e.GoogleProductCategory)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("google_product_category");
        entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id");
        entity.Property(e => e.IdentifierExists)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("identifier_exists");
        entity.Property(e => e.ImageLink)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("image_link");
        entity.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("link");
        entity.Property(e => e.MaxHandlingTime)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("max_handling_time");
        entity.Property(e => e.MinHandlingTime)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("min_handling_time");
        entity.Property(e => e.MobileLink)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("mobile_link");
        entity.Property(e => e.Mpn)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("mpn");
        entity.Property(e => e.Price)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("price");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("product_number");
        entity.Property(e => e.ProductType)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("product_type");
        entity.Property(e => e.ProductTypeExtended)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("product_type_extended");
        entity.Property(e => e.Shipping)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shipping");
        entity.Property(e => e.Title)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("title");
        entity.Property(e => e.TitleCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title_category");
        entity.Property(e => e.UnitPricingMeasure)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("unit_pricing_measure");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DataFeedGoogle> entity);
}

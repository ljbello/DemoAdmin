using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DataFeedUnBxConfiguration : IEntityTypeConfiguration<DataFeedUnBx>
{
    public void Configure(EntityTypeBuilder<DataFeedUnBx> entity)
    {
        entity
                .HasNoKey()
                .ToTable("DataFeedUnBx");

        entity.Property(e => e.ActiveDate)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.AdditionalKeywords)
                .HasMaxLength(128)
                .IsUnicode(false);
        entity.Property(e => e.AdwordsGrouping)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adwords_grouping");
        entity.Property(e => e.AdwordsRedirect)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("adwords_redirect");
        entity.Property(e => e.Availability)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("availability");
        entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("brand");
        entity.Property(e => e.ColorName)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Condition)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("condition");
        entity.Property(e => e.DefaultHeight)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.DefaultWidth)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("description");
        entity.Property(e => e.FilterFullColor)
                .HasMaxLength(15)
                .IsUnicode(false);
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
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("image_link");
        entity.Property(e => e.IsExclusive)
                .HasMaxLength(15)
                .IsUnicode(false);
        entity.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("link");
        entity.Property(e => e.ManufacturerProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.MerchandisingScore)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Occasion)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.Orientation)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.Price)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("price");
        entity.Property(e => e.ProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("product_number");
        entity.Property(e => e.ProductNumber1)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ProductNumber");
        entity.Property(e => e.ProductType)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("product_type");
        entity.Property(e => e.ProductType1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ProductType");
        entity.Property(e => e.ProductUse)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.ProductionType)
                .HasMaxLength(30)
                .IsUnicode(false);
        entity.Property(e => e.Quantity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("quantity");
        entity.Property(e => e.RecentOrderCount)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Shipping)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shipping");
        entity.Property(e => e.StoreId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("StoreID");
        entity.Property(e => e.Style)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.SupplierProductNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.Theme)
                .HasMaxLength(250)
                .IsUnicode(false);
        entity.Property(e => e.Title)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("title");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DataFeedUnBx> entity);
}

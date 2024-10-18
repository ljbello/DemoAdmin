using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductRecommendationConfiguration : IEntityTypeConfiguration<ProductRecommendation>
{
    public void Configure(EntityTypeBuilder<ProductRecommendation> entity)
    {
        entity.HasKey(e => e.ProductRecommendationId).HasName("PK_ProductRecommendation_1");

        entity.ToTable("ProductRecommendation");

        entity.HasIndex(e => new { e.ProductId, e.RecommendedFor, e.StoreId }, "ProductRecommendation_IX1").IsUnique();

        entity.HasIndex(e => new { e.RecommendedFor, e.ProductId, e.StoreId }, "ProductRecommendation_IX2");

        entity.Property(e => e.ProductRecommendationId).HasColumnName("ProductRecommendationID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasDefaultValue(1);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductRecommendation> entity);
}

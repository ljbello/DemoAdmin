using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class StoreProductMerchandisingAlgorithmConfiguration : IEntityTypeConfiguration<StoreProductMerchandisingAlgorithm>
{
    public void Configure(EntityTypeBuilder<StoreProductMerchandisingAlgorithm> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.StoreId, e.MerchandisingSortingParameterId });

        entity.ToTable("StoreProductMerchandisingAlgorithm");

        entity.HasIndex(e => new { e.StoreId, e.MerchandisingSortingParameterId }, "StoreProductMerchandisingAlgorithm_IX1");

        entity.HasIndex(e => e.CalculatedValue, "StoreProductMerchandisingAlgorithm_IX2");

        entity.HasIndex(e => new { e.MerchandisingSortingParameterId, e.CalculatedValue }, "StoreProductMerchandisingAlgorithm_IX3");

        entity.Property(e => e.ProductId).HasColumnName("ProductID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.MerchandisingSortingParameterId).HasColumnName("MerchandisingSortingParameterID");
        entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<StoreProductMerchandisingAlgorithm> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductCollectionConfiguration : IEntityTypeConfiguration<ProductCollection>
{
    public void Configure(EntityTypeBuilder<ProductCollection> entity)
    {
        entity.ToTable("ProductCollection");

        entity.HasIndex(e => new { e.ProductId, e.CollectionId }, "ProductCollection_IX1").IsUnique();

        entity.Property(e => e.ProductCollectionId).HasColumnName("ProductCollectionID");
        entity.Property(e => e.CollectionId).HasColumnName("CollectionID");
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductCollection> entity);
}

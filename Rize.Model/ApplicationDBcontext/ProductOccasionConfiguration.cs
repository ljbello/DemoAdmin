using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductOccasionConfiguration : IEntityTypeConfiguration<ProductOccasion>
{
    public void Configure(EntityTypeBuilder<ProductOccasion> entity)
    {
        entity.ToTable("ProductOccasion");

        entity.HasIndex(e => new { e.ProductId, e.OccasionId }, "ProductOccasion_IX1").IsUnique();

        entity.HasIndex(e => e.OccasionId, "ProductOccasion_IX2");

        entity.Property(e => e.ProductOccasionId).HasColumnName("ProductOccasionID");
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OccasionId).HasColumnName("OccasionID");
        entity.Property(e => e.ProductId).HasColumnName("ProductID");

        entity.HasOne(d => d.Occasion).WithMany(p => p.ProductOccasions)
                .HasForeignKey(d => d.OccasionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOccasion_Occasion");

        entity.HasOne(d => d.Product).WithMany(p => p.ProductOccasions)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductOccasion_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductOccasion> entity);
}

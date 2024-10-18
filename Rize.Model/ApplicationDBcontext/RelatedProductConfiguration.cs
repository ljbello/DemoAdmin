using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class RelatedProductConfiguration : IEntityTypeConfiguration<RelatedProduct>
{
    public void Configure(EntityTypeBuilder<RelatedProduct> entity)
    {
        entity.HasKey(e => new { e.ProductId, e.RelatedProductId, e.TypeId });

        entity.ToTable("RelatedProduct");

        entity.Property(e => e.TypeId).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.RelatedProductNavigation).WithMany(p => p.RelatedProducts)
                .HasForeignKey(d => d.RelatedProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelatedProduct_tblProducts");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<RelatedProduct> entity);
}

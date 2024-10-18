using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductsUpdatedForMerchandiseScoreConfiguration : IEntityTypeConfiguration<ProductsUpdatedForMerchandiseScore>
{
    public void Configure(EntityTypeBuilder<ProductsUpdatedForMerchandiseScore> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ProductsUpdatedForMerchandiseScore");

        entity.Property(e => e.ProcessStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength();
        entity.Property(e => e.ProductId).HasColumnName("ProductID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductsUpdatedForMerchandiseScore> entity);
}

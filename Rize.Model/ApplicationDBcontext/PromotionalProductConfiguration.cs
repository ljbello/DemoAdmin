using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PromotionalProductConfiguration : IEntityTypeConfiguration<PromotionalProduct>
{
    public void Configure(EntityTypeBuilder<PromotionalProduct> entity)
    {
        entity.HasKey(e => e.ProductId);

        entity.ToTable("PromotionalProduct");

        entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("ProductID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PromotionalProduct> entity);
}

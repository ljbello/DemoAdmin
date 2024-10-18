using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductDesignerConfiguration : IEntityTypeConfiguration<ProductDesigner>
{
    public void Configure(EntityTypeBuilder<ProductDesigner> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ProductD__3214EC072F4408BC");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.Name).HasMaxLength(50);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductDesigner> entity);
}

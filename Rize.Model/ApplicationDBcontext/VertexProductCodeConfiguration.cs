using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VertexProductCodeConfiguration : IEntityTypeConfiguration<VertexProductCode>
{
    public void Configure(EntityTypeBuilder<VertexProductCode> entity)
    {
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VertexProductCode> entity);
}

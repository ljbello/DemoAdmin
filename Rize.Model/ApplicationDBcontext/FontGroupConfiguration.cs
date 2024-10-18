using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class FontGroupConfiguration : IEntityTypeConfiguration<FontGroup>
{
    public void Configure(EntityTypeBuilder<FontGroup> entity)
    {
        entity.ToTable("FontGroup");

        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<FontGroup> entity);
}

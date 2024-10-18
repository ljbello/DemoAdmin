using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageTypeConfiguration : IEntityTypeConfiguration<PageType>
{
    public void Configure(EntityTypeBuilder<PageType> entity)
    {
        entity.ToTable("PageType");

        entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageType> entity);
}

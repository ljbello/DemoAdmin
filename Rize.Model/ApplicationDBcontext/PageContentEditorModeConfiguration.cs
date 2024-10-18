using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageContentEditorModeConfiguration : IEntityTypeConfiguration<PageContentEditorMode>
{
    public void Configure(EntityTypeBuilder<PageContentEditorMode> entity)
    {
        entity
                .HasNoKey()
                .ToTable("PageContentEditorMode");

        entity.Property(e => e.Id).ValueGeneratedOnAdd();
        entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageContentEditorMode> entity);
}

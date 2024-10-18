using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CmspageTemplateConfiguration : IEntityTypeConfiguration<CmspageTemplate>
{
    public void Configure(EntityTypeBuilder<CmspageTemplate> entity)
    {
        entity.ToTable("CMSPageTemplate");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.IconUrl).HasMaxLength(150);
        entity.Property(e => e.Name).HasMaxLength(100);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CmspageTemplate> entity);
}

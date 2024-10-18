using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageAddRotatorConfiguration : IEntityTypeConfiguration<PageAddRotator>
{
    public void Configure(EntityTypeBuilder<PageAddRotator> entity)
    {
        entity.HasKey(e => new { e.PageContentId, e.SiteId, e.ImageUrl });

        entity.ToTable("PageAddRotator");

        entity.Property(e => e.PageContentId).HasMaxLength(255);
        entity.Property(e => e.ImageUrl).HasMaxLength(150);
        entity.Property(e => e.AlternateText).HasMaxLength(150);
        entity.Property(e => e.NavigateUrl).HasMaxLength(150);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageAddRotator> entity);
}

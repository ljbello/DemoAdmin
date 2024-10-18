using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PageDesignGroupConfiguration : IEntityTypeConfiguration<PageDesignGroup>
{
    public void Configure(EntityTypeBuilder<PageDesignGroup> entity)
    {
        entity.HasKey(e => new { e.PageDesignGroupId, e.SiteId });

        entity.ToTable("PageDesignGroup");

        entity.Property(e => e.PageDesignGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DesignGroupName)
                .HasMaxLength(200)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PageDesignGroup> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PagePageGroupConfiguration : IEntityTypeConfiguration<PagePageGroup>
{
    public void Configure(EntityTypeBuilder<PagePageGroup> entity)
    {
        entity.HasKey(e => new { e.PageContentId, e.SiteId, e.PageDesignAreaId, e.PageDesignGroupId }).HasName("PK_Page_PageGroup_1");

        entity.ToTable("Page_PageGroup");

        entity.Property(e => e.PageContentId).HasMaxLength(255);
        entity.Property(e => e.PageDesignAreaId)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PageDesignGroupId)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.PageDesignArea).WithMany(p => p.PagePageGroups)
                .HasForeignKey(d => d.PageDesignAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Page_PageGroup_PageDesignArea");

        entity.HasOne(d => d.PageDesignGroup).WithMany(p => p.PagePageGroups)
                .HasForeignKey(d => new { d.PageDesignGroupId, d.SiteId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Page_PageGroup_PageDesignGroup");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PagePageGroup> entity);
}

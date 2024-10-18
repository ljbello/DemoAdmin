using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CmscontentAreaAuditConfiguration : IEntityTypeConfiguration<CmscontentAreaAudit>
{
    public void Configure(EntityTypeBuilder<CmscontentAreaAudit> entity)
    {
        entity.ToTable("CMSContentAreaAudit");

        entity.HasIndex(e => new { e.ContentAreaId, e.PageId, e.PageVersion }, "CMSContentAreaAudit_IX1");

        entity.HasIndex(e => e.ContentAreaId, "CMSContentAreaAudit_IX2");

        entity.Property(e => e.CmscontentAreaAuditId).HasColumnName("CMSContentAreaAuditID");
        entity.Property(e => e.AuditActivity)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.AuditInsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name).HasMaxLength(150);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CmscontentAreaAudit> entity);
}

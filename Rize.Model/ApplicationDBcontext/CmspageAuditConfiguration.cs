using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CmspageAuditConfiguration : IEntityTypeConfiguration<CmspageAudit>
{
    public void Configure(EntityTypeBuilder<CmspageAudit> entity)
    {
        entity.ToTable("CMSPageAudit");

        entity.Property(e => e.CmspageAuditId).HasColumnName("CMSPageAuditID");
        entity.Property(e => e.AuditActivity)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.AuditInsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.HeadingTitle).HasMaxLength(200);
        entity.Property(e => e.MetaDescription).HasMaxLength(800);
        entity.Property(e => e.MetaKeywords).HasMaxLength(400);
        entity.Property(e => e.MetaTitle).HasMaxLength(150);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.PageAliasUrl).HasMaxLength(800);
        entity.Property(e => e.PageUrl).HasMaxLength(800);
        entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CmspageAudit> entity);
}

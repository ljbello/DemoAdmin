using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CmspageConfiguration : IEntityTypeConfiguration<Cmspage>
{
    public void Configure(EntityTypeBuilder<Cmspage> entity)
    {
        entity.HasKey(e => e.PageId);

        entity.ToTable("CMSPage", tb =>
                {
                    tb.HasTrigger("CMSPageAudit_Insert");
                    tb.HasTrigger("CMSPageAudit_Update");
                });

        entity.HasIndex(e => new { e.Active, e.StoreId, e.PageTypeId }, "CMSPage_IX1");

        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.HeadingTitle).HasMaxLength(200);
        entity.Property(e => e.MetaDescription).HasMaxLength(800);
        entity.Property(e => e.MetaKeywords).HasMaxLength(400);
        entity.Property(e => e.MetaTitle).HasMaxLength(150);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.PageAliasUrl).HasMaxLength(800);
        entity.Property(e => e.PageTypeId).HasDefaultValue(1);
        entity.Property(e => e.PageUrl).HasMaxLength(800);
        entity.Property(e => e.TemplateId).HasDefaultValue(1);
        entity.Property(e => e.Version).HasDefaultValue(1);

        entity.HasOne(d => d.Template).WithMany(p => p.Cmspages)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSPage_CMSPageTemplate");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Cmspage> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CmscontentAreaConfiguration : IEntityTypeConfiguration<CmscontentArea>
{
    public void Configure(EntityTypeBuilder<CmscontentArea> entity)
    {
        entity.HasKey(e => e.ContentAreaId);

        entity.ToTable("CMSContentArea", tb =>
                {
                    tb.HasTrigger("CMSContentArea_Insert");
                    tb.HasTrigger("CMSContentArea_Update");
                });

        entity.HasIndex(e => e.PageId, "CMSContentArea_IX1");

        entity.Property(e => e.IsVisible).HasDefaultValue(true);
        entity.Property(e => e.ModifiedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Name).HasMaxLength(150);
        entity.Property(e => e.PageVersion).HasDefaultValue(1);

        entity.HasOne(d => d.Page).WithMany(p => p.CmscontentAreas)
                .HasForeignKey(d => d.PageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CMSContentArea_CMSPage");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CmscontentArea> entity);
}

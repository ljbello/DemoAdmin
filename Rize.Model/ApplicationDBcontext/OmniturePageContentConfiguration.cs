using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OmniturePageContentConfiguration : IEntityTypeConfiguration<OmniturePageContent>
{
    public void Configure(EntityTypeBuilder<OmniturePageContent> entity)
    {
        entity.HasKey(e => new { e.OmniturePageContentId, e.SiteId, e.OmniturePropertyTypeId, e.OmniturePropertyId });

        entity.ToTable("OmniturePageContent");

        entity.Property(e => e.OmniturePageContentId).HasMaxLength(255);
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.OmnitureValue)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.OmnitureProperty).WithMany(p => p.OmniturePageContents)
                .HasForeignKey(d => new { d.OmniturePropertyTypeId, d.OmniturePropertyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OmniturePageContent_OmnitureProperty1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OmniturePageContent> entity);
}

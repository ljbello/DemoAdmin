using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class HtmlContentConfiguration : IEntityTypeConfiguration<HtmlContent>
{
    public void Configure(EntityTypeBuilder<HtmlContent> entity)
    {
        entity.ToTable("HtmlContent");

        entity.HasIndex(e => new { e.Name, e.Updated }, "HtmlContent_IX1");

        entity.HasIndex(e => e.IsPreview, "HtmlContent_IX2");

        entity.HasIndex(e => e.StoreId, "HtmlContent_IX3");

        entity.HasIndex(e => new { e.Name, e.StoreId }, "HtmlContent_IX4");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Content).IsUnicode(false);
        entity.Property(e => e.Created).HasColumnType("datetime");
        entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Published).HasColumnType("datetime");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");
        entity.Property(e => e.Updated).HasColumnType("datetime");
        entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<HtmlContent> entity);
}

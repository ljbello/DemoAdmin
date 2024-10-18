using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class PersonalizationThumbnailConfiguration : IEntityTypeConfiguration<PersonalizationThumbnail>
{
    public void Configure(EntityTypeBuilder<PersonalizationThumbnail> entity)
    {
        entity.HasKey(e => new { e.Id, e.SectionName, e.EmailId });

        entity.ToTable("PersonalizationThumbnail");

        entity.HasIndex(e => new { e.CreatedOn, e.Id }, "PersonalizationThumbnail_IX1");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.SectionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Extracted).HasDefaultValue(true);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<PersonalizationThumbnail> entity);
}

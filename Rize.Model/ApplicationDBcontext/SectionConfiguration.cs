using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SectionConfiguration : IEntityTypeConfiguration<Section>
{
    public void Configure(EntityTypeBuilder<Section> entity)
    {
        entity.ToTable("Section");

        entity.Property(e => e.SectionId).ValueGeneratedNever();
        entity.Property(e => e.EntityCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EntityRank).HasDefaultValue(2147483647);
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Side)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Section> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class WordAbbreviationConfiguration : IEntityTypeConfiguration<WordAbbreviation>
{
    public void Configure(EntityTypeBuilder<WordAbbreviation> entity)
    {
        entity.HasKey(e => new { e.Keyword, e.Exactword });

        entity.ToTable("WordAbbreviation");

        entity.Property(e => e.Keyword)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Exactword)
                .HasMaxLength(500)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<WordAbbreviation> entity);
}

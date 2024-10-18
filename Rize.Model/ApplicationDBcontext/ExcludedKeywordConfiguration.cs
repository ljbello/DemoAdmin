using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ExcludedKeywordConfiguration : IEntityTypeConfiguration<ExcludedKeyword>
{
    public void Configure(EntityTypeBuilder<ExcludedKeyword> entity)
    {
        entity.HasNoKey();

        entity.Property(e => e.Keyword)
                .HasMaxLength(400)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ExcludedKeyword> entity);
}

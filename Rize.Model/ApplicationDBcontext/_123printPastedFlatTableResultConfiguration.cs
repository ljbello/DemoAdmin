using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class _123printPastedFlatTableResultConfiguration : IEntityTypeConfiguration<_123printPastedFlatTableResult>
{
    public void Configure(EntityTypeBuilder<_123printPastedFlatTableResult> entity)
    {
        entity
                .HasNoKey()
                .ToTable("123PrintPastedFlatTableResult");

        entity.Property(e => e.Keyword).HasMaxLength(255);
        entity.Property(e => e.Redirect).HasMaxLength(255);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<_123printPastedFlatTableResult> entity);
}

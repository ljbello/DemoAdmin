using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LgCompareConfiguration : IEntityTypeConfiguration<LgCompare>
{
    public void Configure(EntityTypeBuilder<LgCompare> entity)
    {
        entity
                .HasNoKey()
                .ToTable("LG_COMPARE");

        entity.Property(e => e.Cd)
                .HasMaxLength(32)
                .HasColumnName("CD");
        entity.Property(e => e.Lg)
                .HasMaxLength(32)
                .HasColumnName("LG");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<LgCompare> entity);
}

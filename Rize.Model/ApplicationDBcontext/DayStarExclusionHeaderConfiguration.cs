using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DayStarExclusionHeaderConfiguration : IEntityTypeConfiguration<DayStarExclusionHeader>
{
    public void Configure(EntityTypeBuilder<DayStarExclusionHeader> entity)
    {
        entity.ToTable("DayStarExclusionHeader");

        entity.Property(e => e.DayStarExclusionHeaderId).HasColumnName("DayStarExclusionHeaderID");
        entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DayStarExclusionHeader> entity);
}

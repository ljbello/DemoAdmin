using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ArtworkStatusConfiguration : IEntityTypeConfiguration<ArtworkStatus>
{
    public void Configure(EntityTypeBuilder<ArtworkStatus> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__ArtworkS__3214EC07E95FAFA8");

        entity.ToTable("ArtworkStatus");

        entity.Property(e => e.Id).ValueGeneratedNever();
        entity.Property(e => e.DisplayName).HasMaxLength(100);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ArtworkStatus> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class LandingPageRotatorConfiguration : IEntityTypeConfiguration<LandingPageRotator>
{
    public void Configure(EntityTypeBuilder<LandingPageRotator> entity)
    {
        entity.ToTable("LandingPageRotator");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.PageContentId)
                .HasMaxLength(255)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<LandingPageRotator> entity);
}

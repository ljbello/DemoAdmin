using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class Pv2sectionImageConfiguration : IEntityTypeConfiguration<Pv2sectionImage>
{
    public void Configure(EntityTypeBuilder<Pv2sectionImage> entity)
    {
        entity
                .HasNoKey()
                .ToTable("PV2SectionImage");

        entity.Property(e => e.Back).HasMaxLength(255);
        entity.Property(e => e.BackExt)
                .HasMaxLength(10)
                .IsFixedLength();
        entity.Property(e => e.CompletedBy).HasMaxLength(255);
        entity.Property(e => e.Front).HasMaxLength(255);
        entity.Property(e => e.FrontExt)
                .HasMaxLength(10)
                .IsFixedLength();
        entity.Property(e => e.ImageName).HasMaxLength(255);
        entity.Property(e => e.InsideBottomRight).HasMaxLength(255);
        entity.Property(e => e.InsideBottomRightExt)
                .HasMaxLength(10)
                .IsFixedLength();
        entity.Property(e => e.InsideTopLeft).HasMaxLength(255);
        entity.Property(e => e.InsideTopLeftExt)
                .HasMaxLength(10)
                .IsFixedLength();
        entity.Property(e => e.Name).HasMaxLength(255);
        entity.Property(e => e.Notes).HasMaxLength(255);
        entity.Property(e => e.Orientation).HasMaxLength(255);
        entity.Property(e => e.ProductNumber).HasMaxLength(255);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Pv2sectionImage> entity);
}

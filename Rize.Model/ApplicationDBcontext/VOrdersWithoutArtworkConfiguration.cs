using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class VOrdersWithoutArtworkConfiguration : IEntityTypeConfiguration<VOrdersWithoutArtwork>
{
    public void Configure(EntityTypeBuilder<VOrdersWithoutArtwork> entity)
    {
        entity
                .HasNoKey()
                .ToView("vOrdersWithoutArtwork");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<VOrdersWithoutArtwork> entity);
}

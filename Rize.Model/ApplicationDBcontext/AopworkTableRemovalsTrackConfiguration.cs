using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class AopworkTableRemovalsTrackConfiguration : IEntityTypeConfiguration<AopworkTableRemovalsTrack>
{
    public void Configure(EntityTypeBuilder<AopworkTableRemovalsTrack> entity)
    {
        entity.ToTable("AOPWorkTable_Removals_Track");

        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<AopworkTableRemovalsTrack> entity);
}

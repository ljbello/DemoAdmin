using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class DayStarExclusionDetailConfiguration : IEntityTypeConfiguration<DayStarExclusionDetail>
{
    public void Configure(EntityTypeBuilder<DayStarExclusionDetail> entity)
    {
        entity.ToTable("DayStarExclusionDetail");

        entity.Property(e => e.DayStarExclusionDetailId).HasColumnName("DayStarExclusionDetailID");
        entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
        entity.Property(e => e.DayStarExclusionHeaderId).HasColumnName("DayStarExclusionHeaderID");

        entity.HasOne(d => d.DayStarExclusionHeader).WithMany(p => p.DayStarExclusionDetails)
                .HasForeignKey(d => d.DayStarExclusionHeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DayStarExclusionDetail_DayStarExclusionHeader");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<DayStarExclusionDetail> entity);
}

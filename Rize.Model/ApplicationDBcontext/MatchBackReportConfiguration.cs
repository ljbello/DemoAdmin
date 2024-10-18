using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MatchBackReportConfiguration : IEntityTypeConfiguration<MatchBackReport>
{
    public void Configure(EntityTypeBuilder<MatchBackReport> entity)
    {
        entity.HasKey(e => e.ReportId);

        entity.Property(e => e.ReportId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.EndDate).HasColumnType("datetime");
        entity.Property(e => e.StartDate).HasColumnType("datetime");
        entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MatchBackReport> entity);
}

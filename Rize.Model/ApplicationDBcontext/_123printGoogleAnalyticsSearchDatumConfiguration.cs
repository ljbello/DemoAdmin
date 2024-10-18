using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class _123printGoogleAnalyticsSearchDatumConfiguration : IEntityTypeConfiguration<_123printGoogleAnalyticsSearchDatum>
{
    public void Configure(EntityTypeBuilder<_123printGoogleAnalyticsSearchDatum> entity)
    {
        entity
                .HasNoKey()
                .ToTable("123PrintGoogleAnalyticsSearchData");

        entity.Property(e => e.GaSearchKeyword)
                .HasMaxLength(255)
                .HasColumnName("ga:searchKeyword");
        entity.Property(e => e.GaSearchUniques).HasColumnName("ga:searchUniques");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<_123printGoogleAnalyticsSearchDatum> entity);
}

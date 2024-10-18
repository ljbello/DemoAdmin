using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SearchTermExclusionConfiguration : IEntityTypeConfiguration<SearchTermExclusion>
{
    public void Configure(EntityTypeBuilder<SearchTermExclusion> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SearchTermExclusion");

        entity.Property(e => e.ExclusionWord).IsUnicode(false);
        entity.Property(e => e.SearchTermExclusionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SearchTermExclusionID");
        entity.Property(e => e.StoreId).HasColumnName("StoreID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SearchTermExclusion> entity);
}

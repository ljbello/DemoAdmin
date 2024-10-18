using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TaxCityConfiguration : IEntityTypeConfiguration<TaxCity>
{
    public void Configure(EntityTypeBuilder<TaxCity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__TaxCity__3214EC27844A5F9C");

        entity.ToTable("TaxCity");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
        entity.Property(e => e.StateId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("StateID");
        entity.Property(e => e.Synonym)
                .HasMaxLength(100)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TaxCity> entity);
}

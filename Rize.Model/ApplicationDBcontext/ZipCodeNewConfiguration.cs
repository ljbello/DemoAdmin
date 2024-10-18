using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ZipCodeNewConfiguration : IEntityTypeConfiguration<ZipCodeNew>
{
    public void Configure(EntityTypeBuilder<ZipCodeNew> entity)
    {
        entity
                .HasNoKey()
                .ToTable("ZipCodeNew");

        entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.County)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DaylightSavings)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Fips)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIPS");
        entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Population)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Preferred)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.TimeZone)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ZipId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ZipID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ZipCodeNew> entity);
}

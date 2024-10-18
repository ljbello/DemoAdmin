using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ZipcodeLookupConfiguration : IEntityTypeConfiguration<ZipcodeLookup>
{
    public void Configure(EntityTypeBuilder<ZipcodeLookup> entity)
    {
        entity.HasKey(e => e.Zipcode);

        entity.ToTable("ZipcodeLookup");

        entity.HasIndex(e => e.St, "ZipcodeLookup_IX1");

        entity.Property(e => e.Zipcode)
                .HasMaxLength(12)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false);
        entity.Property(e => e.Country)
                .HasMaxLength(3)
                .IsUnicode(false);
        entity.Property(e => e.Latitude).HasColumnType("numeric(18, 4)");
        entity.Property(e => e.Longitude).HasColumnType("numeric(18, 4)");
        entity.Property(e => e.St)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ST");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ZipcodeLookup> entity);
}

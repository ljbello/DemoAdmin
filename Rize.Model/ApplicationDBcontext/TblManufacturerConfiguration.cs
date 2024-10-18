using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblManufacturerConfiguration : IEntityTypeConfiguration<TblManufacturer>
{
    public void Configure(EntityTypeBuilder<TblManufacturer> entity)
    {
        entity.HasKey(e => e.ManManufacturerId).HasName("tblManufacturers_PK");

        entity.ToTable("tblManufacturers");

        entity.Property(e => e.ManManufacturerId).HasColumnName("Man__ManufacturerID");
        entity.Property(e => e.ManAbbreviation)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Man__Abbreviation");
        entity.Property(e => e.ManName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Man__Name");
        entity.Property(e => e.ManUrl)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Man__URL");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblManufacturer> entity);
}

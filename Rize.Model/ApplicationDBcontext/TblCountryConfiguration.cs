using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCountryConfiguration : IEntityTypeConfiguration<TblCountry>
{
    public void Configure(EntityTypeBuilder<TblCountry> entity)
    {
        entity.HasKey(e => e.CouCountryId);

        entity.ToTable("tblCountries");

        entity.Property(e => e.CouCountryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Cou__CountryID");
        entity.Property(e => e.CouLongName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Cou__LongName");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCountry> entity);
}

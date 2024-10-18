using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStateConfiguration : IEntityTypeConfiguration<TblState>
{
    public void Configure(EntityTypeBuilder<TblState> entity)
    {
        entity.HasKey(e => e.StaStateId).HasName("tblStates_PK");

        entity.ToTable("tblStates");

        entity.HasIndex(e => new { e.StaTaxRate, e.StartCollectingTaxDate }, "tblStates_IX1");

        entity.Property(e => e.StaStateId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Sta__StateID");
        entity.Property(e => e.CouCountryId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Cou__CountryID");
        entity.Property(e => e.StaActive)
                .HasDefaultValue(true)
                .HasColumnName("Sta__Active");
        entity.Property(e => e.StaLongName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Sta__LongName");
        entity.Property(e => e.StaTaxRate)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("Sta__TaxRate");
        entity.Property(e => e.StartCollectingTaxDate).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblState> entity);
}

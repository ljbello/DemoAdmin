using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MatchBackReportsUserDatumConfiguration : IEntityTypeConfiguration<MatchBackReportsUserDatum>
{
    public void Configure(EntityTypeBuilder<MatchBackReportsUserDatum> entity)
    {
        entity.HasKey(e => e.ReportDataId);

        entity.Property(e => e.ReportDataId).HasDefaultValueSql("(newid())");
        entity.Property(e => e.AddressLine1)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Company)
                .HasMaxLength(150)
                .IsUnicode(false);
        entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.MatchType)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false);

        entity.HasOne(d => d.Report).WithMany(p => p.MatchBackReportsUserData)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatchBackReportsUserData_MatchBackReports");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MatchBackReportsUserDatum> entity);
}

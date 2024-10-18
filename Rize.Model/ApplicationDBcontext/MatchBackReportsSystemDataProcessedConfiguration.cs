using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MatchBackReportsSystemDataProcessedConfiguration : IEntityTypeConfiguration<MatchBackReportsSystemDataProcessed>
{
    public void Configure(EntityTypeBuilder<MatchBackReportsSystemDataProcessed> entity)
    {
        entity.HasKey(e => new { e.CustomerId, e.CustomerAddressId });

        entity.ToTable("MatchBackReportsSystemDataProcessed");

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
        entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.LastName)
                .HasMaxLength(50)
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

        entity.HasOne(d => d.CustomerAddress).WithMany(p => p.MatchBackReportsSystemDataProcesseds)
                .HasForeignKey(d => d.CustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatchBackReportsSystemDataProcessed_tblCustomerAddresses");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MatchBackReportsSystemDataProcessed> entity);
}

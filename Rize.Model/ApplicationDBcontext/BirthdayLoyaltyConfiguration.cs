using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class BirthdayLoyaltyConfiguration : IEntityTypeConfiguration<BirthdayLoyalty>
{
    public void Configure(EntityTypeBuilder<BirthdayLoyalty> entity)
    {
        entity.ToTable("BirthdayLoyalty");

        entity.HasIndex(e => e.CustomerLoginId, "IX_BirthdayLoyalty_ByCustomerLoginId");

        entity.HasIndex(e => e.Email, "IX_BirthdayLoyalty_Email");

        entity.Property(e => e.AddressLine1)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.AddressLine2)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Country)
                .HasMaxLength(3)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.FirstName)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.HowHeard)
                .HasMaxLength(300)
                .IsUnicode(false);
        entity.Property(e => e.LastName)
                .HasMaxLength(75)
                .IsUnicode(false);
        entity.Property(e => e.ReferredByEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
        entity.Property(e => e.ZipCode)
                .HasMaxLength(12)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BirthdayLoyalty> entity);
}

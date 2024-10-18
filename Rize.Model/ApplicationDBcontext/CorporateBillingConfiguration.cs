using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CorporateBillingConfiguration : IEntityTypeConfiguration<CorporateBilling>
{
    public void Configure(EntityTypeBuilder<CorporateBilling> entity)
    {
        entity.ToTable("CorporateBilling");

        entity.HasIndex(e => e.EmailAddress, "CorporateBilling");

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        entity.Property(e => e.AccountsPayableContact)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.FaxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.OperatesFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.PurchaseOrder)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CorporateBilling> entity);
}

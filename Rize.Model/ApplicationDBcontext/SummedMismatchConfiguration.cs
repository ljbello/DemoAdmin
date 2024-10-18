using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SummedMismatchConfiguration : IEntityTypeConfiguration<SummedMismatch>
{
    public void Configure(EntityTypeBuilder<SummedMismatch> entity)
    {
        entity
                .HasNoKey()
                .ToTable("Summed_Mismatch");

        entity.Property(e => e.AuthorizeAmount)
                .HasColumnType("money")
                .HasColumnName("Authorize Amount");
        entity.Property(e => e.AuthorizeName)
                .HasMaxLength(129)
                .IsUnicode(false)
                .HasColumnName("Authorize Name");
        entity.Property(e => e.CustomerName)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("Customer Name");
        entity.Property(e => e.Order)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Order #");
        entity.Property(e => e.SettlementAmount)
                .HasColumnType("money")
                .HasColumnName("Settlement Amount");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SummedMismatch> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CreditCardBinRangeConfiguration : IEntityTypeConfiguration<CreditCardBinRange>
{
    public void Configure(EntityTypeBuilder<CreditCardBinRange> entity)
    {
        entity.ToTable("CreditCardBinRange");

        entity.HasIndex(e => e.HighRange, "IX_CreditCardBinRange_HighRange");

        entity.HasIndex(e => e.LowRange, "IX_CreditCardBinRange_LowRange");

        entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsFixedLength();
        entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CreditCardBinRange> entity);
}

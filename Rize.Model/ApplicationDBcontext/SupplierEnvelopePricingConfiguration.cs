using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierEnvelopePricingConfiguration : IEntityTypeConfiguration<SupplierEnvelopePricing>
{
    public void Configure(EntityTypeBuilder<SupplierEnvelopePricing> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SupplierEnvelope_Pricing");

        entity.HasIndex(e => new { e.SupplierEnvelopeAmount, e.SupplierEnvelopeId }, "SupplierEnvelope_Pricing_IX1");

        entity.Property(e => e.SupplierEnvelopeAmount).HasColumnType("money");
        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierEnvelopePricing> entity);
}

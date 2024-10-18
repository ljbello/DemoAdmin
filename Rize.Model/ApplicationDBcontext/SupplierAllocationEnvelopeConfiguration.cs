using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierAllocationEnvelopeConfiguration : IEntityTypeConfiguration<SupplierAllocationEnvelope>
{
    public void Configure(EntityTypeBuilder<SupplierAllocationEnvelope> entity)
    {
        entity.ToTable("SupplierAllocationEnvelope");

        entity.Property(e => e.SupplierAllocationEnvelopeId).HasColumnName("SupplierAllocationEnvelopeID");
        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");
        entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierAllocationEnvelope> entity);
}

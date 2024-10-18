using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierEnvelopeConfiguration : IEntityTypeConfiguration<SupplierEnvelope>
{
    public void Configure(EntityTypeBuilder<SupplierEnvelope> entity)
    {
        entity.ToTable("SupplierEnvelope");

        entity.HasIndex(e => e.SupplierEnvelopeId, "SupplierEnvelope_IX1");

        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierEnvelope> entity);
}

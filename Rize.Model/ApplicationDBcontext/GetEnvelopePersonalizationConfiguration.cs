using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GetEnvelopePersonalizationConfiguration : IEntityTypeConfiguration<GetEnvelopePersonalization>
{
    public void Configure(EntityTypeBuilder<GetEnvelopePersonalization> entity)
    {
        entity
                .HasNoKey()
                .ToView("GetEnvelopePersonalization");

        entity.Property(e => e.EnvelopeId).HasColumnName("EnvelopeID");
        entity.Property(e => e.SupplierEnvelopeId).HasColumnName("SupplierEnvelopeID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GetEnvelopePersonalization> entity);
}

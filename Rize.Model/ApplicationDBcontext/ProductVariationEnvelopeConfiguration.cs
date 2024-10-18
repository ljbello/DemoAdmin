using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductVariationEnvelopeConfiguration : IEntityTypeConfiguration<ProductVariationEnvelope>
{
    public void Configure(EntityTypeBuilder<ProductVariationEnvelope> entity)
    {
        entity.HasKey(e => new { e.ProductVariationId, e.SupplierEnvelopeId });

        entity.ToTable("ProductVariation_Envelope");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductVariationEnvelope> entity);
}

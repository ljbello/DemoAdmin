using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ProductStockRequestsAuditConfiguration : IEntityTypeConfiguration<ProductStockRequestsAudit>
{
    public void Configure(EntityTypeBuilder<ProductStockRequestsAudit> entity)
    {
        entity.HasKey(e => e.ProductStockRequestsAudit1);

        entity.ToTable("ProductStockRequestsAudit");

        entity.Property(e => e.ProductStockRequestsAudit1).HasColumnName("ProductStockRequestsAudit");
        entity.Property(e => e.AuditTs)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AuditTS");
        entity.Property(e => e.XmlRequestStock).HasColumnType("xml");
        entity.Property(e => e.XmlResponseStock).HasColumnType("xml");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ProductStockRequestsAudit> entity);
}

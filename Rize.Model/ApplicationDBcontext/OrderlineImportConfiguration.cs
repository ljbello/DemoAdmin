using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderlineImportConfiguration : IEntityTypeConfiguration<OrderlineImport>
{
    public void Configure(EntityTypeBuilder<OrderlineImport> entity)
    {
        entity.HasKey(e => e.OrderlineId);

        entity.ToTable("OrderlineImport");

        entity.HasIndex(e => new { e.DesignId, e.IsPersonalizationImported }, "OrderlineImport_IX1");

        entity.Property(e => e.OrderlineId).ValueGeneratedNever();
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderlineImport> entity);
}

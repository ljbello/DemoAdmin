using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class SupplierPaperStockConfiguration : IEntityTypeConfiguration<SupplierPaperStock>
{
    public void Configure(EntityTypeBuilder<SupplierPaperStock> entity)
    {
        entity
                .HasNoKey()
                .ToTable("SupplierPaperStock");

        entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<SupplierPaperStock> entity);
}

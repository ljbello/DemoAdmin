using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderPartsAutoChangeConfiguration : IEntityTypeConfiguration<TblOrderPartsAutoChange>
{
    public void Configure(EntityTypeBuilder<TblOrderPartsAutoChange> entity)
    {
        entity.HasKey(e => e.IId).HasName("PK__tblOrderParts_Au__22607467");

        entity.ToTable("tblOrderParts_AutoChanges");

        entity.HasIndex(e => e.ParOrderPartId, "t1");

        entity.HasIndex(e => e.Operation, "tblOrderParts_AutoChanges_IX1");

        entity.HasIndex(e => new { e.SupSupplierId, e.DateStamp }, "tblOrderParts_AutoChanges_IX2");

        entity.Property(e => e.IId).HasColumnName("iID");
        entity.Property(e => e.DateStamp).HasColumnType("datetime");
        entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.ParOrderPartId).HasColumnName("Par__OrderPartID");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderPartsAutoChange> entity);
}

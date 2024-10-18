using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblStoreProductVisitConfiguration : IEntityTypeConfiguration<TblStoreProductVisit>
{
    public void Configure(EntityTypeBuilder<TblStoreProductVisit> entity)
    {
        entity.HasKey(e => e.StoProVisStoreProductVisitId);

        entity.ToTable("tblStoreProductVisits");

        entity.HasIndex(e => new { e.ProProductId, e.VisitDateTime }, "tblStoreProductVisits_IX1");

        entity.HasIndex(e => new { e.StoStoreId, e.ProProductId }, "tblStoreProductVisits_IX2");

        entity.HasIndex(e => new { e.StoStoreId, e.ProProductId, e.VisitDateTime }, "tblStoreProductVisits_IX3");

        entity.Property(e => e.StoProVisStoreProductVisitId).HasColumnName("StoProVis__StoreProductVisitID");
        entity.Property(e => e.ProProductId).HasColumnName("Pro__ProductID");
        entity.Property(e => e.StoStoreId).HasColumnName("Sto__StoreID");
        entity.Property(e => e.VisitDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblStoreProductVisit> entity);
}

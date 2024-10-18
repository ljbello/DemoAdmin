using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomerCatalogRequestCatalogConfiguration : IEntityTypeConfiguration<TblCustomerCatalogRequestCatalog>
{
    public void Configure(EntityTypeBuilder<TblCustomerCatalogRequestCatalog> entity)
    {
        entity.HasKey(e => new { e.CusCatReqCustomerCatalogRequestId, e.CatCatalogId }).HasName("tblCustomerCatalogRequestCatalogs_PK");

        entity.ToTable("tblCustomerCatalogRequestCatalogs", tb => tb.HasTrigger("tblcustomercatalogrequestcatalogs_UpdateDate"));

        entity.Property(e => e.CusCatReqCustomerCatalogRequestId).HasColumnName("CusCatReq__CustomerCatalogRequestID");
        entity.Property(e => e.CatCatalogId).HasColumnName("Cat__CatalogID");
        entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        entity.HasOne(d => d.CatCatalog).WithMany(p => p.TblCustomerCatalogRequestCatalogs)
                .HasForeignKey(d => d.CatCatalogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblCatalogs_tblCustomerCatalogRequestCatalogs_FK1");

        entity.HasOne(d => d.CusCatReqCustomerCatalogRequest).WithMany(p => p.TblCustomerCatalogRequestCatalogs)
                .HasForeignKey(d => d.CusCatReqCustomerCatalogRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblCustomerCatalogRequests_tblCustomerCatalogRequestCatalogs_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomerCatalogRequestCatalog> entity);
}

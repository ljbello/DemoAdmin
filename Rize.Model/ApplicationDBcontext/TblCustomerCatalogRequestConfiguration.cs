using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomerCatalogRequestConfiguration : IEntityTypeConfiguration<TblCustomerCatalogRequest>
{
    public void Configure(EntityTypeBuilder<TblCustomerCatalogRequest> entity)
    {
        entity.HasKey(e => e.CusCatReqCustomerCatalogRequestId).HasName("tblCustomerCatalogRequests_PK");

        entity.ToTable("tblCustomerCatalogRequests", tb => tb.HasTrigger("tblcustomercatalogrequests_UpdateDate"));

        entity.HasIndex(e => new { e.CusCustomerId, e.CusCatReqDateRequested, e.CusAddCustomerAddressId }, "_dta_index_tblCustomerCatalogRequests_7_933578364__K2_K4_K3");

        entity.HasIndex(e => e.CusCatReqDateRequested, "tblCustomerCatalogRequests_IX1");

        entity.Property(e => e.CusCatReqCustomerCatalogRequestId).HasColumnName("CusCatReq__CustomerCatalogRequestID");
        entity.Property(e => e.BasBasketId).HasColumnName("Bas__BasketID");
        entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.CusAddCustomerAddressId).HasColumnName("CusAdd__CustomerAddressID");
        entity.Property(e => e.CusCatReqCodCustomerCatalogRequestCodeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("CR")
                .HasColumnName("CusCatReqCod__CustomerCatalogRequestCodeID");
        entity.Property(e => e.CusCatReqDateRequested)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CusCatReq__DateRequested");
        entity.Property(e => e.CusCatReqKeyCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CusCatReq__KeyCode");
        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.ExcludeReason)
                .HasMaxLength(1000)
                .IsUnicode(false);
        entity.Property(e => e.LabelPrinted).HasColumnType("datetime");
        entity.Property(e => e.UpdateDate).HasColumnType("datetime");

        entity.HasOne(d => d.BasBasket).WithMany(p => p.TblCustomerCatalogRequests)
                .HasForeignKey(d => d.BasBasketId)
                .HasConstraintName("FK_tblCustomerCatalogRequests_tblBasket");

        entity.HasOne(d => d.CusAddCustomerAddress).WithMany(p => p.TblCustomerCatalogRequests)
                .HasForeignKey(d => d.CusAddCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblCustomerAddresses_tblCustomerCatalogRequests_FK1");

        entity.HasOne(d => d.CusCatReqCodCustomerCatalogRequestCode).WithMany(p => p.TblCustomerCatalogRequests)
                .HasForeignKey(d => d.CusCatReqCodCustomerCatalogRequestCodeId)
                .HasConstraintName("FK_tblCustomerCatalogRequests_tblCustomerCatalogRequestCodes");

        entity.HasOne(d => d.CusCustomer).WithMany(p => p.TblCustomerCatalogRequests)
                .HasForeignKey(d => d.CusCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblCustomers_tblCustomerCatalogRequests_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomerCatalogRequest> entity);
}

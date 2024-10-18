using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TmptblCatalogRequestsLabelConfiguration : IEntityTypeConfiguration<TmptblCatalogRequestsLabel>
{
    public void Configure(EntityTypeBuilder<TmptblCatalogRequestsLabel> entity)
    {
        entity.ToTable("tmptblCatalogRequestsLabels");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CatLabelCode)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.CityStateZip)
                .HasMaxLength(49)
                .IsUnicode(false);
        entity.Property(e => e.CusAddAddress1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Address1");
        entity.Property(e => e.CusAddAddress2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Address2");
        entity.Property(e => e.CusAddCompany)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Company");
        entity.Property(e => e.CusAddPhone)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CusAdd__Phone");
        entity.Property(e => e.CusCatReqCustomerCatalogRequestId).HasColumnName("CusCatReq__CustomerCatalogRequestID");
        entity.Property(e => e.CusCatReqDateRequested)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("CusCatReq__DateRequested");
        entity.Property(e => e.CusCustomerId).HasColumnName("Cus__CustomerID");
        entity.Property(e => e.CusDateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Cus__DateCreated");
        entity.Property(e => e.CusEmail)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Cus__Email");
        entity.Property(e => e.CustomerName)
                .HasMaxLength(97)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TmptblCatalogRequestsLabel> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblCustomerCatalogRequestCodeConfiguration : IEntityTypeConfiguration<TblCustomerCatalogRequestCode>
{
    public void Configure(EntityTypeBuilder<TblCustomerCatalogRequestCode> entity)
    {
        entity.HasKey(e => e.CusCatReqProCodCustomerCatalogRequestPromotionCodeId);

        entity.ToTable("tblCustomerCatalogRequestCodes");

        entity.Property(e => e.CusCatReqProCodCustomerCatalogRequestPromotionCodeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CusCatReqProCod__CustomerCatalogRequestPromotionCodeID");
        entity.Property(e => e.CusCatReqProCodDescription)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CusCatReqProCod__Description");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblCustomerCatalogRequestCode> entity);
}

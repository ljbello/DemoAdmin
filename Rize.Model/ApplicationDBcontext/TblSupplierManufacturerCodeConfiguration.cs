using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierManufacturerCodeConfiguration : IEntityTypeConfiguration<TblSupplierManufacturerCode>
{
    public void Configure(EntityTypeBuilder<TblSupplierManufacturerCode> entity)
    {
        entity
                .HasNoKey()
                .ToTable("tblSupplierManufacturerCodes");

        entity.Property(e => e.ManManufacturerId).HasColumnName("Man__ManufacturerID");
        entity.Property(e => e.SupManCodManufacturerCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SupManCod__ManufacturerCode");
        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");


        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplierManufacturerCode> entity);
}

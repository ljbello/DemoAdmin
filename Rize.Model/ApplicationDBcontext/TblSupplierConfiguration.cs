using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSupplierConfiguration : IEntityTypeConfiguration<TblSupplier>
{
    public void Configure(EntityTypeBuilder<TblSupplier> entity)
    {
        entity.HasKey(e => e.SupSupplierId).HasName("tblSuppliers_PK");

        entity.ToTable("tblSuppliers");

        entity.HasIndex(e => e.SupName, "IX_tblSuppliers").IsUnique();

        entity.Property(e => e.SupSupplierId).HasColumnName("Sup__SupplierID");
        entity.Property(e => e.Abbreviation)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.Active).HasDefaultValue(true);
        entity.Property(e => e.CanPrintFoil).HasDefaultValue(true);
        entity.Property(e => e.ContactEmailCancellation)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.ContactEmailDelinquent)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.ContactEmailOrders)
                .HasMaxLength(255)
                .IsUnicode(false);
        entity.Property(e => e.StaStateId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Sta__StateID");
        entity.Property(e => e.SupAccountNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Sup__AccountNumber");
        entity.Property(e => e.SupAccountingPhone)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Sup__AccountingPhone");
        entity.Property(e => e.SupAddress)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Sup__Address");
        entity.Property(e => e.SupAutoOrderProcessEnabled).HasColumnName("Sup__AutoOrderProcessEnabled");
        entity.Property(e => e.SupCity)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Sup__City");
        entity.Property(e => e.SupCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Sup__Code");
        entity.Property(e => e.SupExpectedDpsalesRatio)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("Sup__ExpectedDPSalesRatio");
        entity.Property(e => e.SupFax)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Sup__Fax");
        entity.Property(e => e.SupName)
                .HasMaxLength(48)
                .IsUnicode(false)
                .HasColumnName("Sup__Name");
        entity.Property(e => e.SupNotes)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Sup__Notes");
        entity.Property(e => e.SupOrderStatusEnabled).HasColumnName("Sup__OrderStatusEnabled");
        entity.Property(e => e.SupPhone)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Sup__Phone");
        entity.Property(e => e.SupProductCounter).HasColumnName("Sup__ProductCounter");
        entity.Property(e => e.SupUrl)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Sup__URL");
        entity.Property(e => e.SupZip)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Sup__Zip");

        entity.HasOne(d => d.StaState).WithMany(p => p.TblSuppliers)
                .HasForeignKey(d => d.StaStateId)
                .HasConstraintName("FK_tblSuppliers_tblStates");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSupplier> entity);
}

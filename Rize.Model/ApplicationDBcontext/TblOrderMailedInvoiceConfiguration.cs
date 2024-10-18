using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderMailedInvoiceConfiguration : IEntityTypeConfiguration<TblOrderMailedInvoice>
{
    public void Configure(EntityTypeBuilder<TblOrderMailedInvoice> entity)
    {
        entity.HasKey(e => e.OrdMaiInvOrderMailedInvoiceId).HasName("tblOrderMailedInvoices_PK");

        entity.ToTable("tblOrderMailedInvoices");

        entity.HasIndex(e => e.OrdOrderId, "index_115");

        entity.Property(e => e.OrdMaiInvOrderMailedInvoiceId).HasColumnName("OrdMaiInv__OrderMailedInvoiceID");
        entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("Date_Created");
        entity.Property(e => e.OrdMaiInvAmountDue)
                .HasColumnType("money")
                .HasColumnName("OrdMaiInv__Amount_Due");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.RequestId).HasMaxLength(20);

        entity.HasOne(d => d.OrdOrder).WithMany(p => p.TblOrderMailedInvoices)
                .HasForeignKey(d => d.OrdOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblOrderMailedInvoices_Order_FK1");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderMailedInvoice> entity);
}

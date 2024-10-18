using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class NoTransaction2Configuration : IEntityTypeConfiguration<NoTransaction2>
{
    public void Configure(EntityTypeBuilder<NoTransaction2> entity)
    {
        entity
                .HasNoKey()
                .ToTable("No_Transaction2");

        entity.Property(e => e.CheckAmount)
                .HasColumnType("money")
                .HasColumnName("Check Amount");
        entity.Property(e => e.CheckNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Check Number");
        entity.Property(e => e.CheckReceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("Check Received Date");
        entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Customer Name");
        entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Invoice Number");
        entity.Property(e => e.OrdStaDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrdSta_Description");
        entity.Property(e => e.Order).HasColumnName("Order #");
        entity.Property(e => e.OrderNotes)
                .IsUnicode(false)
                .HasColumnName("Order Notes");
        entity.Property(e => e.SettlementAmount)
                .HasColumnType("money")
                .HasColumnName("Settlement Amount");
        entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Transaction ID");
        entity.Property(e => e.WaitingOnCheck).HasColumnName("Waiting on Check");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<NoTransaction2> entity);
}

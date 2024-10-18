using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderPaymentHistoryConfiguration : IEntityTypeConfiguration<OrderPaymentHistory>
{
    public void Configure(EntityTypeBuilder<OrderPaymentHistory> entity)
    {
        entity
                .HasNoKey()
                .ToView("OrderPaymentHistory");

        entity.Property(e => e.Amount).HasColumnType("money");
        entity.Property(e => e.AmountAuthorized).HasColumnType("money");
        entity.Property(e => e.ApprovalCode)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.AvsZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.Avscode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AVSCode");
        entity.Property(e => e.CheckNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.CreditCardTypeId).HasColumnName("CreditCardTypeID");
        entity.Property(e => e.CustomerPaymentMethodId).HasColumnName("CustomerPaymentMethodID");
        entity.Property(e => e.GatewayFullResponse).IsUnicode(false);
        entity.Property(e => e.HostResponseCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false);
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OrderPaymentActionId).HasColumnName("OrderPaymentActionID");
        entity.Property(e => e.OrderPaymentAuditDate).HasColumnType("datetime");
        entity.Property(e => e.OrderPaymentAuditId).HasColumnName("OrderPaymentAuditID");
        entity.Property(e => e.OrderPaymentId).HasColumnName("OrderPaymentID");
        entity.Property(e => e.OrderPaymentMethodId).HasColumnName("OrderPaymentMethodID");
        entity.Property(e => e.PayerId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PayerID");
        entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
        entity.Property(e => e.ProcessStatusMessage)
                .HasMaxLength(600)
                .IsUnicode(false);
        entity.Property(e => e.ReAuthorizationDate).HasColumnType("datetime");
        entity.Property(e => e.ReAuthorizationId)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
        entity.Property(e => e.RefNum)
                .HasMaxLength(45)
                .IsUnicode(false);
        entity.Property(e => e.RequestData).IsUnicode(false);
        entity.Property(e => e.TransactionId)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("TransactionID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderPaymentHistory> entity);
}

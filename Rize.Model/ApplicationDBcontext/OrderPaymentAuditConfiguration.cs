using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderPaymentAuditConfiguration : IEntityTypeConfiguration<OrderPaymentAudit>
{
    public void Configure(EntityTypeBuilder<OrderPaymentAudit> entity)
    {
        entity.HasKey(e => e.OrderPaymentAuditId).HasName("PK_OrderPaymentsAudit");

        entity.ToTable("OrderPaymentAudit");

        entity.HasIndex(e => e.OrderId, "OrderPaymentAudit_IX1");

        entity.HasIndex(e => e.OrderPaymentId, "OrderPaymentAudit_IX2");

        entity.Property(e => e.OrderPaymentAuditId).HasColumnName("OrderPaymentAuditID");
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
        entity.Property(e => e.OrderPaymentAuditDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
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
        entity.Property(e => e.TpgprofileId).HasColumnName("TPGProfileID");
        entity.Property(e => e.Tpgtoken).HasColumnName("TPGToken");
        entity.Property(e => e.TransactionId)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("TransactionID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderPaymentAudit> entity);
}

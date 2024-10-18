using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblOrderPaymentConfiguration : IEntityTypeConfiguration<TblOrderPayment>
{
    public void Configure(EntityTypeBuilder<TblOrderPayment> entity)
    {
        entity.HasKey(e => e.OrdPayId);

        entity.ToTable("tblOrderPayments", tb => tb.HasTrigger("OrderPaymentAuditTrigger"));

        entity.HasIndex(e => new { e.OrdPayMetOrderPaymentMethodId, e.PayStaPaymentStatusId, e.OrdOrderId }, "_dta_index_tblOrderPayments_5_2056511251__K4_K9_K2");

        entity.HasIndex(e => new { e.PayStaPaymentStatusId, e.OrdOrderId, e.OrdPayId }, "_dta_index_tblOrderPayments_5_2056511251__K9_K2_K1_7");

        entity.HasIndex(e => new { e.OrdOrderId, e.OrdPayMetOrderPaymentMethodId, e.PayStaPaymentStatusId }, "_dta_index_tblOrderPayments_7_2056511251__K2_K4_K9").HasFillFactor(95);

        entity.HasIndex(e => new { e.OrdPayMetOrderPaymentMethodId, e.OrdPayCreditCardNumber }, "index_8399");

        entity.HasIndex(e => new { e.OrdPayMetOrderPaymentMethodId, e.OrdPayReceived }, "tblOrderPayments_IX2");

        entity.HasIndex(e => new { e.OrdPayMetOrderPaymentMethodId, e.PayStaPaymentStatusId, e.OrdPayCreditInformationObfuscationDate, e.OrdPayCreditCardNumber }, "tblOrderPayments_IX3");

        entity.Property(e => e.OrdPayId).HasColumnName("OrdPay__ID");
        entity.Property(e => e.AmountAuthorized).HasColumnType("money");
        entity.Property(e => e.AutAvsCodAvscode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AutAvsCod__AVSCode");
        entity.Property(e => e.AutEchTypAuthorizationEcheckTypeId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AutEchTyp_AuthorizationECheckTypeID");
        entity.Property(e => e.AutResCodResponseCode).HasColumnName("AutResCod__ResponseCode");
        entity.Property(e => e.AutResReaCodResponseReasonCode).HasColumnName("AutResReaCod__ResponseReasonCode");
        entity.Property(e => e.AvsZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.CaptureAttempts).HasDefaultValue(0);
        entity.Property(e => e.CreCarTypCreditCardTypeId).HasColumnName("CreCarTyp__CreditCardTypeID");
        entity.Property(e => e.CustomerPaymentMethodId).HasColumnName("CustomerPaymentMethodID");
        entity.Property(e => e.GatewayFullResponse).IsUnicode(false);
        entity.Property(e => e.HostResponseCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        entity.Property(e => e.Last4Digits)
                .HasMaxLength(4)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.OrdOrderId).HasColumnName("Ord__OrderID");
        entity.Property(e => e.OrdPayAmount)
                .HasColumnType("money")
                .HasColumnName("OrdPay__Amount");
        entity.Property(e => e.OrdPayApprovalCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdPay__ApprovalCode");
        entity.Property(e => e.OrdPayCheckNumber)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OrdPay__Check_Number");
        entity.Property(e => e.OrdPayCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("OrdPay__Created");
        entity.Property(e => e.OrdPayCreditCardExpirationMonth).HasColumnName("OrdPay__CreditCard_ExpirationMonth");
        entity.Property(e => e.OrdPayCreditCardExpirationYear).HasColumnName("OrdPay__CreditCard_ExpirationYear");
        entity.Property(e => e.OrdPayCreditCardNumber)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("OrdPay__CreditCard_Number");
        entity.Property(e => e.OrdPayCreditInformationObfuscationDate)
                .HasColumnType("datetime")
                .HasColumnName("OrdPay__CreditInformationObfuscationDate");
        entity.Property(e => e.OrdPayInvoice).HasColumnName("OrdPay__Invoice");
        entity.Property(e => e.OrdPayMetOrderPaymentMethodId).HasColumnName("OrdPayMet__OrderPaymentMethodID");
        entity.Property(e => e.OrdPayName)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OrdPay__Name");
        entity.Property(e => e.OrdPayReceived)
                .HasColumnType("datetime")
                .HasColumnName("OrdPay__Received");
        entity.Property(e => e.OrdPayResponseSubCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OrdPay__ResponseSubCode");
        entity.Property(e => e.OrdPayTransactionId)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("OrdPay__TransactionID");
        entity.Property(e => e.OrderPaymentActionId).HasColumnName("OrderPaymentActionID");
        entity.Property(e => e.PayStaPaymentStatusId).HasColumnName("PaySta__PaymentStatusID");
        entity.Property(e => e.PayerId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PayerID");
        entity.Property(e => e.ProcessStatusMessage)
                .HasMaxLength(600)
                .IsUnicode(false);
        entity.Property(e => e.ReAuthorizationDate).HasColumnType("datetime");
        entity.Property(e => e.ReAuthorizationId)
                .HasMaxLength(20)
                .IsUnicode(false);
        entity.Property(e => e.RefNum)
                .HasMaxLength(45)
                .IsUnicode(false);
        entity.Property(e => e.RequestData).IsUnicode(false);
        entity.Property(e => e.TpgprofileId).HasColumnName("TPGProfileID");
        entity.Property(e => e.Tpgtoken).HasColumnName("TPGToken");

        entity.HasOne(d => d.AutEchTypAuthorizationEcheckType).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.AutEchTypAuthorizationEcheckTypeId)
                .HasConstraintName("FK_tblOrderPayments_tblAuthorizationECheckTypes");

        entity.HasOne(d => d.AutResCodResponseCodeNavigation).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.AutResCodResponseCode)
                .HasConstraintName("FK_tblOrderPayments_tblAuthorizationResponseCodes");

        entity.HasOne(d => d.AutResReaCodResponseReasonCodeNavigation).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.AutResReaCodResponseReasonCode)
                .HasConstraintName("FK_tblOrderPayments_tblAuthorizationResponseReasonCodes");

        entity.HasOne(d => d.CreCarTypCreditCardType).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.CreCarTypCreditCardTypeId)
                .HasConstraintName("FK_tblOrderPayments_tblCreditCardTypes");

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TblOrderPaymentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_tblOrderPayments_Created");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TblOrderPaymentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_tblOrderPayments_Modified");

        entity.HasOne(d => d.OrdOrder).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.OrdOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderPayments_Order");

        entity.HasOne(d => d.OrdPayMetOrderPaymentMethod).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.OrdPayMetOrderPaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblOrderPayments_tblOrderPaymentMethods");

        entity.HasOne(d => d.OrderPaymentAction).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.OrderPaymentActionId)
                .HasConstraintName("FK_tblOrderPayments_OrderPaymentAction");

        entity.HasOne(d => d.PayStaPaymentStatus).WithMany(p => p.TblOrderPayments)
                .HasForeignKey(d => d.PayStaPaymentStatusId)
                .HasConstraintName("FK_tblOrderPayments_tblPaymentStatus");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblOrderPayment> entity);
}

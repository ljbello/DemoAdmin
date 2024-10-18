using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderPayment
{
    public int OrdPayId { get; set; }

    public int OrdOrderId { get; set; }

    public DateTime OrdPayCreated { get; set; }

    public int OrdPayMetOrderPaymentMethodId { get; set; }

    public string? OrdPayTransactionId { get; set; }

    public string? OrdPayApprovalCode { get; set; }

    public decimal? OrdPayAmount { get; set; }

    public string? OrdPayName { get; set; }

    public int? PayStaPaymentStatusId { get; set; }

    public string? AutAvsCodAvscode { get; set; }

    public int? AutResCodResponseCode { get; set; }

    public int? AutResReaCodResponseReasonCode { get; set; }

    public string? OrdPayResponseSubCode { get; set; }

    public int? CreatedBy { get; set; }

    public bool OrdPayInvoice { get; set; }

    public string? OrdPayCheckNumber { get; set; }

    public DateTime? OrdPayReceived { get; set; }

    public string? AutEchTypAuthorizationEcheckTypeId { get; set; }

    public int? CreCarTypCreditCardTypeId { get; set; }

    public string? OrdPayCreditCardNumber { get; set; }

    public int? OrdPayCreditCardExpirationMonth { get; set; }

    public int? OrdPayCreditCardExpirationYear { get; set; }

    public DateTime? OrdPayCreditInformationObfuscationDate { get; set; }

    public decimal? AmountAuthorized { get; set; }

    public string? RefNum { get; set; }

    public string? AvsZipCode { get; set; }

    public int? ApprovalStatus { get; set; }

    public string? HostResponseCode { get; set; }

    public string? ProcessStatusMessage { get; set; }

    public string? GatewayFullResponse { get; set; }

    public int? CustomerPaymentMethodId { get; set; }

    public string? PayerId { get; set; }

    public string? ReAuthorizationId { get; set; }

    public DateTime? ReAuthorizationDate { get; set; }

    public int? CaptureAttempts { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? OrderPaymentActionId { get; set; }

    public string? RequestData { get; set; }

    public bool? SubmittedForLevel3 { get; set; }

    public string? Last4Digits { get; set; }

    public Guid? TpgprofileId { get; set; }

    public Guid? Tpgtoken { get; set; }

    public virtual TblAuthorizationEcheckType? AutEchTypAuthorizationEcheckType { get; set; }

    public virtual TblAuthorizationResponseCode? AutResCodResponseCodeNavigation { get; set; }

    public virtual TblAuthorizationResponseReasonCode? AutResReaCodResponseReasonCodeNavigation { get; set; }

    public virtual TblCreditCardType? CreCarTypCreditCardType { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Order OrdOrder { get; set; } = null!;

    public virtual TblOrderPaymentMethod OrdPayMetOrderPaymentMethod { get; set; } = null!;

    public virtual OrderPaymentAction? OrderPaymentAction { get; set; }

    public virtual TblPaymentStatus? PayStaPaymentStatus { get; set; }
}

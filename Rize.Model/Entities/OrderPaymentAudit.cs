using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderPaymentAudit
{
    public int OrderPaymentAuditId { get; set; }

    public DateTime OrderPaymentAuditDate { get; set; }

    public int OrderPaymentId { get; set; }

    public int OrderId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int OrderPaymentMethodId { get; set; }

    public string? TransactionId { get; set; }

    public string? ApprovalCode { get; set; }

    public decimal? Amount { get; set; }

    public string? Name { get; set; }

    public int? PaymentStatusId { get; set; }

    public string? Avscode { get; set; }

    public int? CreatedBy { get; set; }

    public bool IncludeOnInvoice { get; set; }

    public string? CheckNumber { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public int? CreditCardTypeId { get; set; }

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

    public Guid? TpgprofileId { get; set; }

    public Guid? Tpgtoken { get; set; }
}

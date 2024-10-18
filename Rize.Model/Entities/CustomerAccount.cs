using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerAccount
{
    public Guid CustomerAccountId { get; set; }

    public Guid CustomerLoginId { get; set; }

    public string? ContactName { get; set; }

    public string? ContactLastName { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactEmailAddress { get; set; }

    public string? BillingFirstName { get; set; }

    public string? BillingLastName { get; set; }

    public string? BillingCompany { get; set; }

    public string? BillingCountryId { get; set; }

    public string? BillingAddressLine1 { get; set; }

    public string? BillingAddressLine2 { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public string? BillingZipCode { get; set; }

    public string? BillingPhoneNumber { get; set; }

    public string? ShippingFirstName { get; set; }

    public string? ShippingLastName { get; set; }

    public string? ShippingCompany { get; set; }

    public string? ShippingCountryId { get; set; }

    public string? ShippingAddressLine1 { get; set; }

    public string? ShippingAddressLine2 { get; set; }

    public string? ShippingCity { get; set; }

    public string? ShippingState { get; set; }

    public string? ShippingZipCode { get; set; }

    public string? ShippingPhoneNumber { get; set; }

    public DateTime? TaxExemptUploadDate { get; set; }

    public byte[]? TaxExemptFileData { get; set; }

    public string? TaxExemptFileExtension { get; set; }

    public decimal CreditLimit { get; set; }

    public virtual ICollection<CustomerAccountCredit> CustomerAccountCredits { get; set; } = new List<CustomerAccountCredit>();

    public virtual CustomerLogin CustomerLogin { get; set; } = null!;
}

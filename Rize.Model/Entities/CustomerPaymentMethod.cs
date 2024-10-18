using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerPaymentMethod
{
    public int Id { get; set; }

    public Guid CustomerLoginId { get; set; }

    public int MethodId { get; set; }

    public Guid? CorporateBillingRefId { get; set; }

    public string? Name { get; set; }

    public string? Ccnumber { get; set; }

    public string? Ccname { get; set; }

    public int? CctypeId { get; set; }

    public int? CcexpMonth { get; set; }

    public int? CcexpYear { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

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

    public string? Last4Digits { get; set; }

    public bool IsDefault { get; set; }

    public Guid? TpgprofileId { get; set; }
}

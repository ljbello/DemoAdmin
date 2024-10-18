using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class BirthdayLoyalty
{
    public int BirthdayLoyaltyId { get; set; }

    public Guid? CustomerLoginId { get; set; }

    public Guid? ReferredByCustomerLoginId { get; set; }

    public string? ReferredByEmail { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? Country { get; set; }

    public string ZipCode { get; set; } = null!;

    public int BirthMonth { get; set; }

    public int BirthDay { get; set; }

    public bool SignUpForEmail { get; set; }

    public string? HowHeard { get; set; }

    public DateTime? CreatedOn { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SampleKitRequest
{
    public int SampleKitRequestId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string Email { get; set; } = null!;

    public string? Country { get; set; }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public bool SendPromotions { get; set; }

    public DateTime Created { get; set; }

    public int StoreId { get; set; }

    public virtual Store Store { get; set; } = null!;
}

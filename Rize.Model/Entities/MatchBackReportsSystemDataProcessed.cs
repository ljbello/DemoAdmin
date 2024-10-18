using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class MatchBackReportsSystemDataProcessed
{
    public int CustomerId { get; set; }

    public int CustomerAddressId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Company { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public bool Processed { get; set; }

    public virtual TblCustomerAddress CustomerAddress { get; set; } = null!;
}

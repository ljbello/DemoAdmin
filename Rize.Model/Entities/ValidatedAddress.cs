using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ValidatedAddress
{
    public int ValidatedAddressId { get; set; }

    public int CustomerAddressId { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public bool ExactMatch { get; set; }

    public bool NoSuggestions { get; set; }
}

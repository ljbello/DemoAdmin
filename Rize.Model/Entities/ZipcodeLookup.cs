using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ZipcodeLookup
{
    public string? Country { get; set; }

    public string? City { get; set; }

    public string? St { get; set; }

    public string Zipcode { get; set; } = null!;

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }
}

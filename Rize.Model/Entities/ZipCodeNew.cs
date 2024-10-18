using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ZipCodeNew
{
    public string? Zip { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? Area { get; set; }

    public string? Fips { get; set; }

    public string? TimeZone { get; set; }

    public string? DaylightSavings { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? Type { get; set; }

    public string? Preferred { get; set; }

    public string? Population { get; set; }

    public string? Country { get; set; }

    public long ZipId { get; set; }
}

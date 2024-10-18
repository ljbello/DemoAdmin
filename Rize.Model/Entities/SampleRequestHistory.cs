using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SampleRequestHistory
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public int Total { get; set; }

    public string UserIp { get; set; } = null!;

    public int StoreId { get; set; }

    public string? EmailAddress { get; set; }

    public string? AddressLine1 { get; set; }

    public string? City { get; set; }
}

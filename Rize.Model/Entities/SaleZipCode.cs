using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SaleZipCode
{
    public double? ZipCode { get; set; }

    public string? StateId { get; set; }

    public double? TotalOrderValue { get; set; }
}

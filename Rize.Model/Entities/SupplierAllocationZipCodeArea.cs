using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierAllocationZipCodeArea
{
    public int ZipCodeAreaId { get; set; }

    public int SupplierId { get; set; }

    public string? Zip3 { get; set; }

    public int? MinDays { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierUpsmaxOrderCount
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public DateOnly Date { get; set; }

    public int MaxOrderCount { get; set; }
}

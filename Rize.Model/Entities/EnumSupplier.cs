using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EnumSupplier
{
    public int SuppliersId { get; set; }

    public string SuppliersName { get; set; } = null!;

    public string? SuppliersDescription { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ImportedProductTypeMapping
{
    public int OldProductId { get; set; }

    public string OldProductName { get; set; } = null!;

    public int ProductTypeId { get; set; }

    public bool ReadyMapped { get; set; }

    public bool ReadyImage { get; set; }
}

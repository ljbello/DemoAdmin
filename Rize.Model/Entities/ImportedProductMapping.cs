using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ImportedProductMapping
{
    public double? ProductTypeId { get; set; }

    public double? ThemeId { get; set; }

    public string? ProductNumber { get; set; }
}

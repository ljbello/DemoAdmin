using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ImportedProductDesignMapping
{
    public int ProductId { get; set; }

    public int DesignId { get; set; }

    public int ThemeId { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public int ProductTypeId { get; set; }
}

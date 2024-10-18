using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ImportedPaperStockFinishMapping
{
    public int ProductFacetValueId { get; set; }

    public int PaperStockFinishId { get; set; }

    public string LegacyName { get; set; } = null!;
}

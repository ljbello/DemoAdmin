using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderLineLayoutAreaCustomizationsFrombackup
{
    public int? OrdLinLayAreCusOrderLineLayoutAreaCustomizationId { get; set; }

    public int? OrdLinOrderLineId { get; set; }

    public int? LayAreLayoutAreaId { get; set; }

    public string? OrdLinLayAreCusXml { get; set; }

    public int? OrdLinLayAreCusImprintType { get; set; }
}

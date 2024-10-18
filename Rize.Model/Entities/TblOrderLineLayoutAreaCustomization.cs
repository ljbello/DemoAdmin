using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderLineLayoutAreaCustomization
{
    public int OrdLinLayAreCusOrderLineLayoutAreaCustomizationId { get; set; }

    public int OrdLinOrderLineId { get; set; }

    public int LayAreLayoutAreaId { get; set; }

    public string OrdLinLayAreCusXml { get; set; } = null!;

    public int OrdLinLayAreCusImprintType { get; set; }

    public virtual TblLayoutArea LayAreLayoutArea { get; set; } = null!;

    public virtual TblOrderLine OrdLinOrderLine { get; set; } = null!;
}

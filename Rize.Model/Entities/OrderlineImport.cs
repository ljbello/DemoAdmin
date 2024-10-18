using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderlineImport
{
    public int OrderlineId { get; set; }

    public bool IsPersonalizationImported { get; set; }

    public int DesignId { get; set; }

    public int OriginalOrderId { get; set; }

    public int OriginalOrderItemId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? ConversionError { get; set; }

    public DateTime? UpdatedOn { get; set; }
}

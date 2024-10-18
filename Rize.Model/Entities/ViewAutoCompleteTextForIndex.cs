using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewAutoCompleteTextForIndex
{
    public string? Description { get; set; }

    public int? StoreId { get; set; }

    public long? TokenLength { get; set; }

    public string SearchType { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SearchTermExclusion
{
    public long SearchTermExclusionId { get; set; }

    public int StoreId { get; set; }

    public string ExclusionWord { get; set; } = null!;
}

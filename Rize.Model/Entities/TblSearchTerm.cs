using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSearchTerm
{
    public int SeaTerSearchTermId { get; set; }

    public string SeaTerSearchTerm { get; set; } = null!;

    public int SeaTerSearchCount { get; set; }

    public int StoStoreId { get; set; }

    public virtual Store StoStore { get; set; } = null!;
}

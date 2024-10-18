using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSearchTermRedirect
{
    public int SeaTerRedSearchTermRedirectId { get; set; }

    public int StoStoreId { get; set; }

    public string SeaTerRedSearchTerm { get; set; } = null!;

    public string? SeaTerRedSearchTermSynonyms { get; set; }

    public string SeaTerRedDestinationPage { get; set; } = null!;

    public bool SeaTerRedDestinationPageIsCompleteUrl { get; set; }

    public virtual Store StoStore { get; set; } = null!;
}

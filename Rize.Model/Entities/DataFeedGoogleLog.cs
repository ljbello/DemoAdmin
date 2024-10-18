using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DataFeedGoogleLog
{
    public string? ProductId { get; set; }

    public string? ProductType { get; set; }

    public int? StoreId { get; set; }

    public string ProcessStatus { get; set; } = null!;

    public DateTime InsertDate { get; set; }

    public bool? ChangedRecord { get; set; }
}

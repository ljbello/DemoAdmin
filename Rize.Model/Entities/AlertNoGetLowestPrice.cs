using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AlertNoGetLowestPrice
{
    public DateTime? AlertTime { get; set; }

    public int? StoreId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class UspsorderLine
{
    public int OrderLineId { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly EventDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateOnly ShippedDate { get; set; }
}

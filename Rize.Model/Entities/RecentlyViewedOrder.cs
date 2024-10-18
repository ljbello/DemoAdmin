using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class RecentlyViewedOrder
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public DateTime CreatedOn { get; set; }
}

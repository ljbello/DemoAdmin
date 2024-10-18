using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderlineStatusAudit
{
    public int Id { get; set; }

    public int? OrderLineId { get; set; }

    public int? OrderStatusId { get; set; }

    public DateTime? OrderStatusChangeDate { get; set; }

    public int ModifedBy { get; set; }
}

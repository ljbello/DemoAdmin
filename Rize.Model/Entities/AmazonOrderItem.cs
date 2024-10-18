using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AmazonOrderItem
{
    public int Id { get; set; }

    public int AmazonOrderRefId { get; set; }

    public int OrderLineId { get; set; }

    public string AmazonSku { get; set; } = null!;

    public string? OrderItemId { get; set; }

    public int? LineNumber { get; set; }

    public virtual AmazonOrder AmazonOrderRef { get; set; } = null!;
}

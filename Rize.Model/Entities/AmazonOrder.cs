using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AmazonOrder
{
    public int Id { get; set; }

    public string AmazonOrderId { get; set; } = null!;

    public int OrderId { get; set; }

    public decimal OrderTotal { get; set; }

    public DateTime PurchaseDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime LastUpdatedOn { get; set; }

    public bool ShipFulfillmentSubmitted { get; set; }

    public int StoreId { get; set; }

    public virtual ICollection<AmazonOrderItem> AmazonOrderItems { get; set; } = new List<AmazonOrderItem>();

    public virtual Store Store { get; set; } = null!;
}

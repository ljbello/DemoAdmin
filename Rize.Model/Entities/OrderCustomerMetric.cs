using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderCustomerMetric
{
    public long OrderId { get; set; }

    public Guid? CustomerGroupId { get; set; }

    public string? CustomerStatus { get; set; }

    public DateTime? PreviousOrderDate { get; set; }

    public int? TwelveMonthOrderCount { get; set; }

    public decimal? TwelveMonthAov { get; set; }

    public decimal? TwelveMonthOrderValue { get; set; }

    public int? AllTimeOrders { get; set; }

    public decimal? AllTimeAov { get; set; }

    public decimal? AllTimeValue { get; set; }

    public string? ProductTypes { get; set; }

    public DateTime? InsertTs { get; set; }

    public DateTime? UpdateTs { get; set; }

    public DateTime? FirstOrderDate { get; set; }
}

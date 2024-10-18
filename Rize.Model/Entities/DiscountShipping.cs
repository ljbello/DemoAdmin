using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DiscountShipping
{
    public Guid DiscountShippingId { get; set; }

    public int DepartmentId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int ShippingMethodId { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}

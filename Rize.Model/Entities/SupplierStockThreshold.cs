using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierStockThreshold
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int LowerQuantity { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;
}

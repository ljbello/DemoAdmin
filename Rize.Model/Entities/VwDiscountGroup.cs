using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VwDiscountGroup
{
    public int DiscountGroupId { get; set; }

    public int ProductTypeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int Storeid { get; set; }

    public int Startqty { get; set; }

    public decimal Discountamount { get; set; }
}

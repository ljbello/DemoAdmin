using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class LowestPrice
{
    public int ProProductId { get; set; }

    public decimal? SalePrice { get; set; }

    public int StoStoreId { get; set; }

    public DateTime? InsertDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

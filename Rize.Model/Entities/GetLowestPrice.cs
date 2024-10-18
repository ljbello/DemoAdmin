using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetLowestPrice
{
    public int ProProductId { get; set; }

    public decimal? SalePrice { get; set; }

    public int StoStoreId { get; set; }
}

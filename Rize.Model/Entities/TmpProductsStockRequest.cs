using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TmpProductsStockRequest
{
    public Guid SessionGuid { get; set; }

    public string ProSupplierProductNumber { get; set; } = null!;

    public DateTime DateCreated { get; set; }
}

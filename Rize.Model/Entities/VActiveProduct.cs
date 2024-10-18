using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VActiveProduct
{
    public int ProProductId { get; set; }

    public int SupSupplierId { get; set; }

    public string? ProSupplierProductNumber { get; set; }

    public int? ProSampleSupplierId { get; set; }

    public DateTime? ProSampleOnOrderDate { get; set; }

    public int ProStaProductStatusId { get; set; }

    public int StoStoreId { get; set; }
}

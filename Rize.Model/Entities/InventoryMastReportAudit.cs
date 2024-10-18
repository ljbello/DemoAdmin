using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class InventoryMastReportAudit
{
    public string? ProductNumber { get; set; }

    public int? ProProductId { get; set; }

    public string? SupplierNumber { get; set; }

    public int? TotalQuantity { get; set; }

    public int? Inflight { get; set; }

    public int? NumberofSales { get; set; }

    public int? Status { get; set; }

    public int? Cads1 { get; set; }

    public int? Cads3 { get; set; }

    public int? Cads5 { get; set; }

    public int? Cadsh { get; set; }

    public int? Cadsl { get; set; }

    public int? AvailQ { get; set; }

    public int? SupSupplierId { get; set; }

    public string? TStatus { get; set; }

    public int? StoProNumberOfSales { get; set; }

    public int? StoProDisplayOffset { get; set; }

    public int? NewDisplayOffset { get; set; }

    public DateTime? InsertDate { get; set; }
}

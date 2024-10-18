using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierOrderInvoiceSchema
{
    public int SupplierOrderInvoiceSchemaId { get; set; }

    public int? SchemaFirstColumnIndex { get; set; }

    public string? DiskFileName { get; set; }

    public string? SheetName { get; set; }

    public bool? HeaderNames { get; set; }

    public string? Account { get; set; }

    public string? PoNumber { get; set; }

    public string? Invoice { get; set; }

    public string? InvoiceDate { get; set; }

    public string? ShipmentMode { get; set; }

    public string? TotalCharges { get; set; }

    public string? ShippingCharge { get; set; }

    public string? CreditOrDebit { get; set; }

    public string? EnvCharge { get; set; }

    public string? Handling { get; set; }

    public string? Freight { get; set; }

    public string? Total { get; set; }

    public string? Tracking { get; set; }
}

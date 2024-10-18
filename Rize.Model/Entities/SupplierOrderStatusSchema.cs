using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierOrderStatusSchema
{
    public int SupplierOrderStatusSchemaId { get; set; }

    public int? SchemaFirstColumnIndex { get; set; }

    public string? DiskFileName { get; set; }

    public string? SheetName { get; set; }

    public bool? HeaderNames { get; set; }

    public string? Account { get; set; }

    public string? Invoice { get; set; }

    public string? InvoiceDate { get; set; }

    public string? Quantity { get; set; }

    public string? Code { get; set; }

    public string? Book { get; set; }

    public string? SupplierPart { get; set; }

    public string? Imprint { get; set; }

    public string? OrderNumber { get; set; }

    public string? OrderStatus { get; set; }

    public string? ShippingDate { get; set; }

    public string? ShippingCharge { get; set; }

    public string? ShipMethod { get; set; }

    public string? TrackingLink { get; set; }

    public string? TrackingNumber { get; set; }

    public string? ShippingMethod { get; set; }

    public string? StatusDate { get; set; }
}

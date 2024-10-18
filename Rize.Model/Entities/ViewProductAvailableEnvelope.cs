using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewProductAvailableEnvelope
{
    public int ProductId { get; set; }

    public int ProductVariationId { get; set; }

    public bool IsDefault { get; set; }

    public int SupplierEnvelopeId { get; set; }

    public int SupplierId { get; set; }

    public int EnvelopeId { get; set; }

    public string SupplierEnvelopeCode { get; set; } = null!;

    public string? SupEnvPreviewTemplateName { get; set; }

    public string? SupEnvProductionTemplateName { get; set; }

    public int? ManufacturerId { get; set; }

    public string? ManufacturerItemNumber { get; set; }

    public string? SupplierEnvelopeDescription { get; set; }

    public string? EnvelopeImage { get; set; }

    public bool ExtraPostageRequired { get; set; }

    public int SortOrder { get; set; }

    public string? EnvelopeDescription { get; set; }

    public string? EnvelopeTypeId { get; set; }

    public string? EnvelopeTypeDescription { get; set; }

    public int? AlternateSupplierEnvelopeId { get; set; }

    public int? AlternateEnvelopeSupplierId { get; set; }

    public int? AlternateEnvelopeId { get; set; }

    public string? AlternateEnvelopeCode { get; set; }

    public string? AlternateEnvelopeDescription { get; set; }

    public string? AlternateEnvelopeTypeId { get; set; }

    public string? AlternateSupplierEnvelopeDescription { get; set; }

    public int InkColorGroupId { get; set; }
}

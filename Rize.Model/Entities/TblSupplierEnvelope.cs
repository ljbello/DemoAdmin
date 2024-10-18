using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblSupplierEnvelope
{
    public int SupEnvSupplierEnvelopeId { get; set; }

    public int SupSupplierId { get; set; }

    public int EnvEnvelopeId { get; set; }

    public string SupEnvSupplierEnvelopeCode { get; set; } = null!;

    public string? SupEnvPreviewTemplateName { get; set; }

    public string? SupEnvProductionTemplateName { get; set; }

    public int? ManManufacturerId { get; set; }

    public string? SupEnvManufacturerItemNumber { get; set; }

    public string? SupEnvEnvelopeImage { get; set; }

    public bool SupEnvExtraPostageRequired { get; set; }

    public int SupEnvSortOrder { get; set; }

    public int InkColorGroupId { get; set; }

    public bool? AllowAddressing { get; set; }

    public bool? AllowMailing { get; set; }

    public bool AllowFlapPrinting { get; set; }

    public bool AllowFrontPrinting { get; set; }

    public bool AllowStamping { get; set; }

    public bool? IsActive { get; set; }

    public int? AlternativeEnvelopeId { get; set; }

    public string? CartDisclaimer { get; set; }

    public virtual TblSupplierEnvelope? AlternativeEnvelope { get; set; }

    public virtual ICollection<AmazonProductMapping> AmazonProductMappings { get; set; } = new List<AmazonProductMapping>();

    public virtual Envelope EnvEnvelope { get; set; } = null!;

    public virtual ICollection<TblSupplierEnvelope> InverseAlternativeEnvelope { get; set; } = new List<TblSupplierEnvelope>();

    public virtual TblManufacturer? ManManufacturer { get; set; }

    public virtual ICollection<ProductProductVariationSupplierEnvelope> ProductProductVariationSupplierEnvelopes { get; set; } = new List<ProductProductVariationSupplierEnvelope>();

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual ICollection<SupplierEnvelopeSection> SupplierEnvelopeSections { get; set; } = new List<SupplierEnvelopeSection>();

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();
}

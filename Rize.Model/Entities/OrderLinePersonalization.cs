using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLinePersonalization
{
    public int OrderLineId { get; set; }

    public string PersonalizationXml { get; set; } = null!;

    public bool? HasImageScan { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? VariationId { get; set; }

    public int? PaperstockFinishId { get; set; }

    public int? SupplierEnvelopeId { get; set; }

    public int EnvelopePrintingCode { get; set; }

    public string? VariationOptionId { get; set; }

    public Guid? ThumbnailId { get; set; }

    public string? Browser { get; set; }

    public string? LastEditNotes { get; set; }

    public string? PersonalizationJson { get; set; }

    public string? PunchOutConfigId { get; set; }

    public string? PunchOutThumbnailUrl { get; set; }

    public virtual TblOrderLine OrderLine { get; set; } = null!;

    public virtual PaperStockFinish? PaperstockFinish { get; set; }
}

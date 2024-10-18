using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderlinePersonalizationAudit
{
    public long OrderLinePersonalizationId { get; set; }

    public int OrderLineId { get; set; }

    public string PersonalizationXml { get; set; } = null!;

    public string ActionTaken { get; set; } = null!;

    public DateTime DateChanged { get; set; }

    public int? ModifiedBy { get; set; }

    public int? VariationId { get; set; }

    public int? PaperStockFinishId { get; set; }

    public int? SupplierEnvelopeId { get; set; }

    public int EnvelopePrintingCode { get; set; }

    public string? VariationOptionId { get; set; }

    public Guid? ThumbnailId { get; set; }

    public string? Browser { get; set; }

    public string? Notes { get; set; }

    public string? PersonalizationJson { get; set; }

    public string? PunchOutConfigId { get; set; }

    public string? PunchOutThumbnailUrl { get; set; }
}

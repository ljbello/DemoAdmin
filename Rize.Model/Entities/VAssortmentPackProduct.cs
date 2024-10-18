using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VAssortmentPackProduct
{
    public int AssortmentPackImageId { get; set; }

    public int PackProductId { get; set; }

    public int? SizeId { get; set; }

    public string? FrontImage { get; set; }

    public string? VerseImage { get; set; }

    public int EntityRank { get; set; }

    public DateTime EntityCreated { get; set; }

    public DateTime? EntityUpdated { get; set; }

    public bool EntityInactive { get; set; }

    public int EnvelopeId { get; set; }

    public string? ProductNumber { get; set; }

    public string? Orientation { get; set; }

    public int? ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string SizeName { get; set; } = null!;

    public string EnvelopeName { get; set; } = null!;

    public int? StoStoreId { get; set; }

    public int NumberPerDesign { get; set; }

    public int Rating { get; set; }

    public int VariationId { get; set; }
}

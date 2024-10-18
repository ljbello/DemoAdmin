using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AssortmentPackImage
{
    public int AssortmentPackImageId { get; set; }

    public int PackProductId { get; set; }

    public int? SizeId { get; set; }

    public string FrontImage { get; set; } = null!;

    public string? VerseImage { get; set; }

    public int EntityRank { get; set; }

    public DateTime EntityCreated { get; set; }

    public DateTime? EntityUpdated { get; set; }

    public bool EntityInactive { get; set; }

    public int EnvelopeId { get; set; }

    public string? ProductNumber { get; set; }

    public string? Orientation { get; set; }

    public int NumberPerDesign { get; set; }

    public virtual AssortmentPack PackProduct { get; set; } = null!;
}

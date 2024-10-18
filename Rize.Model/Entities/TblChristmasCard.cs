using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblChristmasCard
{
    public int ProProductId { get; set; }

    public bool ChrCarRecycled { get; set; }

    public string? ChrCarDefaultVerseId { get; set; }

    public bool ChrCarAssemblyRequired { get; set; }

    public bool ChrCarExtraPostageRequired { get; set; }

    public int? AlbAlbumId { get; set; }

    public int EnvEnvelopeId { get; set; }

    public int SizSizeId { get; set; }

    public bool ChrCarPostCard { get; set; }

    public bool ChrCarPhotoCard { get; set; }

    public bool ChrCarSoldInPacks { get; set; }

    public int? ChrCarCardsPerPack { get; set; }

    public string? SupEnvSupplierEnvelopeCode { get; set; }

    public string ChrCarCardOrientation { get; set; } = null!;

    public string ChrCarStandardVerseImageOrientation { get; set; } = null!;

    public decimal ChrCarVerseScaleFactor { get; set; }

    public bool ChrCarPanelCard { get; set; }

    public int InkColorGroupId { get; set; }

    public bool? ChrCarHolidayCard { get; set; }

    public virtual Envelope EnvEnvelope { get; set; } = null!;

    public virtual InkColorGroup InkColorGroup { get; set; } = null!;

    public virtual TblProduct ProProduct { get; set; } = null!;

    public virtual TblSize SizSize { get; set; } = null!;
}

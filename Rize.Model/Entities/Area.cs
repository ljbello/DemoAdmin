using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Area
{
    public int AreaId { get; set; }

    public int LayoutId { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int AreaTypeId { get; set; }

    public string? AreaMode { get; set; }

    public bool AllowVerse { get; set; }

    public int Rotation { get; set; }

    public int MaxImages { get; set; }

    public int Layer { get; set; }

    public int? DefaultVerseId { get; set; }

    public string? AreaText { get; set; }

    public int VerticalAlignmentTypeId { get; set; }

    public int HorizontalAlignmentTypeId { get; set; }

    public string? PreviewImage { get; set; }

    public string? PlateImage { get; set; }

    public bool Locked { get; set; }

    public bool DropShadow { get; set; }

    public string? ColorHex { get; set; }

    public DateTime EntityCreated { get; set; }

    public DateTime? EntityUpdated { get; set; }

    public string? EntityUpdatedBy { get; set; }

    public int InkColorGroupId { get; set; }

    public int? AreaNameId { get; set; }

    public bool IsWatermark { get; set; }

    public virtual AreaName? AreaName { get; set; }

    public virtual AreaType AreaType { get; set; } = null!;

    public virtual TblHorizontalAlignmentType HorizontalAlignmentType { get; set; } = null!;

    public virtual InkColorGroup InkColorGroup { get; set; } = null!;

    public virtual Layout Layout { get; set; } = null!;

    public virtual TblVerticalAlignmentType VerticalAlignmentType { get; set; } = null!;
}

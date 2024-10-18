using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblLayoutArea
{
    public int LayAreLayoutAreaId { get; set; }

    public int LayLayoutId { get; set; }

    public int LayAreTypLayoutAreaTypeId { get; set; }

    public int LayAreLeft { get; set; }

    public int LayAreTop { get; set; }

    public int LayAreWidth { get; set; }

    public int LayAreHeight { get; set; }

    public int LayAreRotation { get; set; }

    public int HorAliTypHorizontalAlignmentTypeId { get; set; }

    public int VerAliTypVerticalAlignmentTypeId { get; set; }

    public virtual TblHorizontalAlignmentType HorAliTypHorizontalAlignmentType { get; set; } = null!;

    public virtual TblLayoutAreaType LayAreTypLayoutAreaType { get; set; } = null!;

    public virtual TblLayout LayLayout { get; set; } = null!;

    public virtual ICollection<TblOrderLineLayoutAreaCustomization> TblOrderLineLayoutAreaCustomizations { get; set; } = new List<TblOrderLineLayoutAreaCustomization>();

    public virtual TblVerticalAlignmentType VerAliTypVerticalAlignmentType { get; set; } = null!;
}

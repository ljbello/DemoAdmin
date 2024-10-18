using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblGraphicType
{
    public int GraTypGraphicTypeId { get; set; }

    public string GraTypDescription { get; set; } = null!;

    public string GraTypAbbreviation { get; set; } = null!;

    public virtual ICollection<TblOrderLineGraphic> TblOrderLineGraphics { get; set; } = new List<TblOrderLineGraphic>();
}

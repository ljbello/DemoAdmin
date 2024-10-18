using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblGraphicColor
{
    public int GraColGraphicColorId { get; set; }

    public int OrdLinGraOrderLineGraphicId { get; set; }

    public byte GraColSequence { get; set; }

    public string GraColImprintColor { get; set; } = null!;

    public string? GraColComment { get; set; }

    public virtual TblOrderLineGraphic OrdLinGraOrderLineGraphic { get; set; } = null!;
}

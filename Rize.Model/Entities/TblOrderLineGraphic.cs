using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderLineGraphic
{
    public int OrdLinGraOrderLineGraphicId { get; set; }

    public int OrdLinOrderLineId { get; set; }

    public int AreAreaId { get; set; }

    public byte OrdLinGraSequence { get; set; }

    public int? GraTypGraphicTypeId { get; set; }

    public string? OrdLinGraGraphicTcpipaddress { get; set; }

    public string? OrdLinGraGraphicDirectory { get; set; }

    public string? OrdLinGraGraphicFileName { get; set; }

    public bool OrdLinGraShowInDieCut { get; set; }

    public string? OrdLinGraComment { get; set; }

    public virtual TblArea AreArea { get; set; } = null!;

    public virtual TblGraphicType? GraTypGraphicType { get; set; }

    public virtual ICollection<TblGraphicColor> TblGraphicColors { get; set; } = new List<TblGraphicColor>();
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblChristmasCardsOrderLineCustomText
{
    public int ChrCarOrdLinCusTexCustomTextId { get; set; }

    public int OrdLinOrderLineId { get; set; }

    public int AreAreaId { get; set; }

    public int ChrCarOrdLinCusTexLineNumber { get; set; }

    public string? ChrCarOrdLinCusTexText { get; set; }

    public int? TypTypestyleId { get; set; }

    public decimal? ChrCarOrdLinCusTexPointSize { get; set; }

    public decimal? ChrCarOrdLinCusTexAmount { get; set; }

    public DateTime CreateTimeStamp { get; set; }

    public virtual TblArea AreArea { get; set; } = null!;

    public virtual TblOrderLine OrdLinOrderLine { get; set; } = null!;

    public virtual TblTypestyle? TypTypestyle { get; set; }
}

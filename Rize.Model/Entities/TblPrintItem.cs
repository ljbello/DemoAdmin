using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblPrintItem
{
    public int PriItePrintItemId { get; set; }

    public string PriIteDescription { get; set; } = null!;

    public virtual ICollection<TblArea> AreAreas { get; set; } = new List<TblArea>();
}

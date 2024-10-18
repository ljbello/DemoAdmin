using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderPartsAutoChange
{
    public int IId { get; set; }

    public int ParOrderPartId { get; set; }

    public int SupSupplierId { get; set; }

    public DateTime DateStamp { get; set; }

    public string Operation { get; set; } = null!;
}

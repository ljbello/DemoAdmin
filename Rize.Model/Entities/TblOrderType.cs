using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderType
{
    public int OrdTypOrderTypeId { get; set; }

    public string OrdTypDescription { get; set; } = null!;
}

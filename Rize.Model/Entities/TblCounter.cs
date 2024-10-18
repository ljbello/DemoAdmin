using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCounter
{
    public string CouCounterId { get; set; } = null!;

    public int CouCounterValue { get; set; }
}

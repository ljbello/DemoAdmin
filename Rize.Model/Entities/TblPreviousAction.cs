using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblPreviousAction
{
    public Guid? CusCustomerGroupId { get; set; }

    public string? ActionType { get; set; }

    public DateTime? ActionTime { get; set; }

    public int? ActionMonth { get; set; }

    public int? ActionDay { get; set; }

    public int? ActionYear { get; set; }

    public int? ActionId { get; set; }
}

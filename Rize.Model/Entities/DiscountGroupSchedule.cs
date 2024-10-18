using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DiscountGroupSchedule
{
    public int DiscountGroupScheduleId { get; set; }

    public string Name { get; set; } = null!;

    public int DiscountGroupId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual DiscountGroup DiscountGroup { get; set; } = null!;
}

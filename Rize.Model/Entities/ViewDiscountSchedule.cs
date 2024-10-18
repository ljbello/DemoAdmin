using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewDiscountSchedule
{
    public int DiscountGroupId { get; set; }

    public string DiscountGroupName { get; set; } = null!;

    public int ProductTypeId { get; set; }

    public int StoreId { get; set; }

    public int DiscountGroupScheduleId { get; set; }

    public string ScheduleName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime CreatedOn { get; set; }
}

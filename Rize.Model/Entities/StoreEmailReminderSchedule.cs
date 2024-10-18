using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StoreEmailReminderSchedule
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string ReminderType { get; set; } = null!;

    public int DaysAgo { get; set; }

    public string SubscriberEmailCode { get; set; } = null!;

    public bool Active { get; set; }

    public int? EmailTypeId { get; set; }
}

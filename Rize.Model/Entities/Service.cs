using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Service
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ServiceTypeId { get; set; }

    public int HeartbeatFrequency { get; set; }

    public string? Command { get; set; }

    public int StatusTypeId { get; set; }

    public DateTime? LastHeartbeat { get; set; }

    public string? CurrentVersion { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeOnly? ScheduledBeginTime { get; set; }

    public string Interval { get; set; } = null!;

    public int Frequency { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ServiceFeed? ServiceFeed { get; set; }

    public virtual ICollection<ServiceMessage> ServiceMessages { get; set; } = new List<ServiceMessage>();

    public virtual ServiceType ServiceType { get; set; } = null!;

    public virtual ServiceStatusType StatusType { get; set; } = null!;
}

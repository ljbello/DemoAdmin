using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ServiceMessage
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public int ServiceMessageTypeId { get; set; }

    public string? Message { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Service Service { get; set; } = null!;

    public virtual ServiceMessageType ServiceMessageType { get; set; } = null!;
}

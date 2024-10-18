using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ServiceMessageType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<ServiceMessage> ServiceMessages { get; set; } = new List<ServiceMessage>();
}

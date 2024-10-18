using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ServiceStatusType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? Created { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}

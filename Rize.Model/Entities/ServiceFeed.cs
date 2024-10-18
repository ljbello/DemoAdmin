using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ServiceFeed
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ServiceId { get; set; }

    public string? RemoteAddress { get; set; }

    public string? RemoteUser { get; set; }

    public string? RemotePassword { get; set; }

    public string? Path { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Service Service { get; set; } = null!;
}

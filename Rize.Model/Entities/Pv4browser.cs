using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Pv4browser
{
    public int Id { get; set; }

    public string Browser { get; set; } = null!;

    public string? MinimumVersion { get; set; }

    public string? UserAgent { get; set; }

    public string? CompatibleDevice { get; set; }

    public bool Enabled { get; set; }
}

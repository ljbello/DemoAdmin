using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailErrorResolution
{
    public int Id { get; set; }

    public string ResolutionText { get; set; } = null!;

    public string ErrorContainText { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Pv2sectionImage
{
    public string? ProductNumber { get; set; }

    public string? ImageName { get; set; }

    public string? Name { get; set; }

    public string? Orientation { get; set; }

    public string? Front { get; set; }

    public string? Back { get; set; }

    public string? InsideTopLeft { get; set; }

    public string? InsideBottomRight { get; set; }

    public string? CompletedBy { get; set; }

    public string? Notes { get; set; }

    public string? FrontExt { get; set; }

    public string? BackExt { get; set; }

    public string? InsideTopLeftExt { get; set; }

    public string? InsideBottomRightExt { get; set; }
}

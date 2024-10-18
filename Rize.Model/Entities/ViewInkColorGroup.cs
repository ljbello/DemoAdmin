using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ViewInkColorGroup
{
    public int InkColorId { get; set; }

    public int ProductTypeId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsFoil { get; set; }

    public string? Icsmcolor { get; set; }

    public string? Rgb { get; set; }

    public string? Pmscode { get; set; }

    public short? Red { get; set; }

    public short? Green { get; set; }

    public short? Blue { get; set; }

    public short Type { get; set; }

    public int InkColorGroupId { get; set; }

    public int? Position { get; set; }
}

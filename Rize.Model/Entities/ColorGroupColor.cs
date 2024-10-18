using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ColorGroupColor
{
    public int Id { get; set; }

    public int ColorGroupId { get; set; }

    public string ColorName { get; set; } = null!;

    public virtual ColorGroup ColorGroup { get; set; } = null!;
}

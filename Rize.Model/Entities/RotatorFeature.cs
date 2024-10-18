using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class RotatorFeature
{
    public int RotatorFeatureId { get; set; }

    public int StoreId { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsImage { get; set; }

    public string? Image { get; set; }

    public string? Link { get; set; }

    public string? HtmlContent { get; set; }

    public int SortOrder { get; set; }
}

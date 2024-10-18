using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLineBusinessFlagKeyword
{
    public int Id { get; set; }

    public string? Keyword { get; set; }

    public int? OnlyForPreviewVersion { get; set; }

    public string? ExclusionKeyword { get; set; }
}

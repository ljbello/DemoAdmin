using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AutoCompleteText
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? StoreId { get; set; }

    public int? TokenLength { get; set; }

    public string? SearchType { get; set; }
}

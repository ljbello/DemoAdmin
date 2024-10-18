using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class HtmlContent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Content { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsPreview { get; set; }

    public int? StoreId { get; set; }

    public DateTime? Published { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? Updated { get; set; }

    public string? UpdatedBy { get; set; }
}

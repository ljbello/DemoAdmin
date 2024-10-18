using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderTagKey
{
    public int TagId { get; set; }

    public string DisplayName { get; set; } = null!;

    public bool AllowSubmission { get; set; }

    public bool IsSearchable { get; set; }

    public string? TagCode { get; set; }

    public virtual ICollection<OrderTag> OrderTags { get; set; } = new List<OrderTag>();
}

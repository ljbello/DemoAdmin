using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminUserPost
{
    public int PostId { get; set; }

    public string Title { get; set; } = null!;

    public string PostContent { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? PublishedOn { get; set; }

    public bool IsPublished { get; set; }
}

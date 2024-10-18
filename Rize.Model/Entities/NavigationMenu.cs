using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class NavigationMenu
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string TabHtml { get; set; } = null!;

    public string BodyHtml { get; set; } = null!;

    public string Styles { get; set; } = null!;

    public bool Active { get; set; }

    public bool Preview { get; set; }

    public int? StoreId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? PublishedOn { get; set; }
}

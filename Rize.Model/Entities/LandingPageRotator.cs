using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class LandingPageRotator
{
    public int Id { get; set; }

    public string PageContentId { get; set; } = null!;

    public int ProductId { get; set; }
}

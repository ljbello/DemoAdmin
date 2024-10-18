using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OmniturePageContent
{
    public string OmniturePageContentId { get; set; } = null!;

    public int SiteId { get; set; }

    public int OmniturePropertyTypeId { get; set; }

    public int OmniturePropertyId { get; set; }

    public string? OmnitureValue { get; set; }

    public DateTime EntityCreated { get; set; }

    public virtual OmnitureProperty OmnitureProperty { get; set; } = null!;
}

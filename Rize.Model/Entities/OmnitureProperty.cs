using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OmnitureProperty
{
    public int OmniturePropertyTypeId { get; set; }

    public int OmniturePropertyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime EntityCreated { get; set; }

    public virtual ICollection<OmniturePageContent> OmniturePageContents { get; set; } = new List<OmniturePageContent>();

    public virtual OmniturePropertyType OmniturePropertyType { get; set; } = null!;
}

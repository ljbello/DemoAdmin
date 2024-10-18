using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OmniturePropertyType
{
    public int OmniturePropertyTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime EntityCreated { get; set; }

    public virtual ICollection<OmnitureProperty> OmnitureProperties { get; set; } = new List<OmnitureProperty>();
}

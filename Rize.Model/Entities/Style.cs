using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Style
{
    public int StyleId { get; set; }

    public string StyleName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual ICollection<ProductStyle> ProductStyles { get; set; } = new List<ProductStyle>();
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class FaqCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<FaqItem> FaqItems { get; set; } = new List<FaqItem>();
}

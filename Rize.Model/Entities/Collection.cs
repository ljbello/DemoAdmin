using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Collection
{
    public int CollectionId { get; set; }

    public string CollectionName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}

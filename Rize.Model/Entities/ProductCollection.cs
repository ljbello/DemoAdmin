using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductCollection
{
    public int ProductCollectionId { get; set; }

    public int ProductId { get; set; }

    public int CollectionId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;
}

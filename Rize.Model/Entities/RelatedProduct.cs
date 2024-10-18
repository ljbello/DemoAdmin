using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class RelatedProduct
{
    public int ProductId { get; set; }

    public int RelatedProductId { get; set; }

    public int Sort { get; set; }

    public int TypeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual TblProduct RelatedProductNavigation { get; set; } = null!;
}

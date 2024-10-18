using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductImage
{
    public int Id { get; set; }

    public string ImageName { get; set; } = null!;

    public short SortIndex { get; set; }

    public int ImageTypeId { get; set; }

    public bool IsVisible { get; set; }

    public string? AltTitle { get; set; }

    public int ProductId { get; set; }

    public DateTime ModifiedOn { get; set; }

    public int ModifiedBy { get; set; }

    public virtual TblUser ModifiedByNavigation { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;

    public virtual ICollection<ProductOptionImage> ProductOptionImages { get; set; } = new List<ProductOptionImage>();
}

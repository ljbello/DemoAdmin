using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductOptionImage
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int PriceGroupId { get; set; }

    public string OptionKey { get; set; } = null!;

    public int ProductImageId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblProduct Product { get; set; } = null!;

    public virtual ProductImage ProductImage { get; set; } = null!;
}

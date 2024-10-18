using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductColor
{
    public int ProductColorId { get; set; }

    public int ProductId { get; set; }

    public int? R { get; set; }

    public int? G { get; set; }

    public int? B { get; set; }

    public string? HexCode { get; set; }

    public decimal? Percentage { get; set; }

    public string? ColorName { get; set; }

    public int? Position { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual TblProduct Product { get; set; } = null!;
}

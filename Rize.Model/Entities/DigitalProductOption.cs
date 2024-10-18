using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DigitalProductOption
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public short Type { get; set; }

    public string Spc { get; set; } = null!;

    public int? VariationId { get; set; }

    public virtual TblProduct Product { get; set; } = null!;
}

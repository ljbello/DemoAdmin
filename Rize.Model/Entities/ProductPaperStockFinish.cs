using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductPaperStockFinish
{
    public int ProductId { get; set; }

    public int ProductVariationId { get; set; }

    public int PaperStockFinishId { get; set; }

    public int StoreId { get; set; }

    public bool IsDefault { get; set; }

    public bool IsActive { get; set; }

    public virtual PaperStockFinish PaperStockFinish { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}

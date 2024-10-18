using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductConstructorCode
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int VariationId { get; set; }

    public int ProductType { get; set; }

    public int? PaperStockFinishId { get; set; }

    public string? VarOption { get; set; }

    public string? PointConstructorCode { get; set; }

    public string? ProductionConstructorCode { get; set; }

    public string? StockCode { get; set; }

    public string? InternalNotes { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public int ModifiedBy { get; set; }

    public virtual TblUser ModifiedByNavigation { get; set; } = null!;

    public virtual ProductType ProductTypeNavigation { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;

    public virtual ProductVariation Variation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductOptionGroup
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int VariationId { get; set; }

    public int StoreId { get; set; }

    public int PriceGroupId { get; set; }

    public bool Active { get; set; }

    public string FriendlyName { get; set; } = null!;

    public int? PriceGroupIdToOverride { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual ProductOptionPriceGroup PriceGroup { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}

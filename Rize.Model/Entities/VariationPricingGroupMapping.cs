using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class VariationPricingGroupMapping
{
    public int ProductvariationId { get; set; }

    public bool DigitalPressPhotoCard { get; set; }

    public bool Charity { get; set; }

    public bool? HolidayCard { get; set; }

    public int SupplierPricinggroupId { get; set; }

    public DateTime InsertDatetime { get; set; }

    public long MappingId { get; set; }

    public int StoreId { get; set; }

    public int? ProductTypeId { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual ProductType? ProductType { get; set; }

    public virtual ProductVariation Productvariation { get; set; } = null!;

    public virtual TblSupplierPricing SupplierPricinggroup { get; set; } = null!;
}

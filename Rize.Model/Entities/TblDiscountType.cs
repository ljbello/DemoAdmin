using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblDiscountType
{
    public int DisTypDiscountTypeId { get; set; }

    public string? DisTypDiscountTypeDescription { get; set; }

    public int ClassId { get; set; }

    public string? Class { get; set; }

    public virtual ICollection<TblDiscount> TblDiscounts { get; set; } = new List<TblDiscount>();
}

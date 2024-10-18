using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblInkColor
{
    public int InkColInkColorId { get; set; }

    public int ProTypProductTypeId { get; set; }

    public string InkColName { get; set; } = null!;

    public bool InkColIsFoil { get; set; }

    public string? InkColIcsmcolor { get; set; }

    public string? InkColRgb { get; set; }

    public string? InkColPmscode { get; set; }

    public short? InkColRed { get; set; }

    public short? InkColGreen { get; set; }

    public short? InkColBlue { get; set; }

    public short InkColType { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual ICollection<InkColorGroupInkColor> InkColorGroupInkColors { get; set; } = new List<InkColorGroupInkColor>();

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual ProductType ProTypProductType { get; set; } = null!;

    public virtual ICollection<TblOrderLine> TblOrderLines { get; set; } = new List<TblOrderLine>();

    public virtual ICollection<TblSupplierInkColor> TblSupplierInkColors { get; set; } = new List<TblSupplierInkColor>();

    public virtual ICollection<TblProduct> ProProducts { get; set; } = new List<TblProduct>();
}

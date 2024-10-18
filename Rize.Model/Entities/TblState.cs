using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblState
{
    public string StaStateId { get; set; } = null!;

    public string? StaLongName { get; set; }

    public decimal StaTaxRate { get; set; }

    public bool StaActive { get; set; }

    public string? CouCountryId { get; set; }

    public DateTime? StartCollectingTaxDate { get; set; }

    public virtual ICollection<TblSupplierState> TblSupplierStates { get; set; } = new List<TblSupplierState>();

    public virtual ICollection<TblSupplier> TblSuppliers { get; set; } = new List<TblSupplier>();
}

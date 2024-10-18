using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierProductType
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public int ProductTypeId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public short ProductionHours { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblRedirect
{
    public int RedRedirectId { get; set; }

    public int StoStoreId { get; set; }

    public int RedRedirectType { get; set; }

    public string RedSourceUrl { get; set; } = null!;

    public string RedDestinationUrl { get; set; } = null!;

    public DateTime RedEffectiveDate { get; set; }

    public DateTime? RedEndDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Store StoStore { get; set; } = null!;
}

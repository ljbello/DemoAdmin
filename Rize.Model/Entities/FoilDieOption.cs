using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class FoilDieOption
{
    public int Id { get; set; }

    public string FoilDieCode { get; set; } = null!;

    public string ImageName { get; set; } = null!;

    public int VariationId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblUser? ModifiedByNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class MerchandisingSortingParameter
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public string? ParameterName { get; set; }

    public int? TimeFrameInDays { get; set; }

    public double? AlgorithmWeight { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? IncludeInCalculation { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual TblUser? CreatedByNavigation { get; set; }

    public virtual TblUser? ModifiedByNavigation { get; set; }

    public virtual Store Store { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblBatchTransmission
{
    public int BatTraBatchTransmissionsId { get; set; }

    public DateTime? BatTraDateTimeSubmitted { get; set; }

    public DateTime? BatTraDateTimeCompleted { get; set; }

    public bool? BatTraHasError { get; set; }

    public string? BitTraBatchLog { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<TblBatchTransmissionsOrderPart> TblBatchTransmissionsOrderParts { get; set; } = new List<TblBatchTransmissionsOrderPart>();

    public virtual TblUser User { get; set; } = null!;
}

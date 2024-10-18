using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderSubmissionStatus
{
    public int OrdSubStaOrderSubmissionStatusId { get; set; }

    public string OrdSubStaDescription { get; set; } = null!;

    public int OrdSubStaSequence { get; set; }

    public virtual ICollection<TblOrderLineSubmissionGraphicFile> TblOrderLineSubmissionGraphicFiles { get; set; } = new List<TblOrderLineSubmissionGraphicFile>();
}

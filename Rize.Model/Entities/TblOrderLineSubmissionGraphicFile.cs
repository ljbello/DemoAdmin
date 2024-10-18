using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderLineSubmissionGraphicFile
{
    public int Id { get; set; }

    public int OrdLinOrderLineId { get; set; }

    public int AreAreaId { get; set; }

    public int OrdLinDtppart { get; set; }

    public string OrdLinSubGraFilGraphicFileName { get; set; } = null!;

    public int OrdSubStaOrderSubmissionStatusId { get; set; }

    public DateTime OrdLinSubGraFilDateSubmitted { get; set; }

    public DateTime? OrdLinSubGraFilDateVerified { get; set; }

    public DateTime OrdLinSubGraFilDateCreated { get; set; }

    public virtual TblArea AreArea { get; set; } = null!;

    public virtual TblOrderSubmissionStatus OrdSubStaOrderSubmissionStatus { get; set; } = null!;
}

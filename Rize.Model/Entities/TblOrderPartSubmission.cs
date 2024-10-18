using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderPartSubmission
{
    public int ParOrderPartId { get; set; }

    public DateTime? OrdParSubDateSubmitted { get; set; }

    public string? OrdParSubSubmissionType { get; set; }

    public string? OrdParSubXmlfileNameRequest { get; set; }

    public string? OrdParSubXmlfileNameResponse { get; set; }

    public int? OrdSubStaOrderSubmissionStatusId { get; set; }

    public DateTime? OrdParSubDateVerified { get; set; }

    public DateTime? OrdParSubDateLastRequest { get; set; }

    public int? OrdParSubTotalRequests { get; set; }

    public DateTime OrdParSubDateCreated { get; set; }

    public virtual TblOrderSubmissionStatus? OrdSubStaOrderSubmissionStatus { get; set; }
}

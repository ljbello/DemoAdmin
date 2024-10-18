using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomerProofStatus
{
    public int ProStaProofStatusId { get; set; }

    public string? ProStaDescription { get; set; }

    public int? ProStaProofSequence { get; set; }

    public string? ProStaFriendlyName { get; set; }
}

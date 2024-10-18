using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProductsDtpinvalid
{
    public string ProProductNumber { get; set; } = null!;

    public DateTime? ProDtpInvDateActive { get; set; }

    public string? ProDtpInvNotes { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Email
{
    public long EmailId { get; set; }

    public DateTime InsertDate { get; set; }

    public string EmailStatus { get; set; } = null!;

    public string Recipients { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? Body { get; set; }

    public string? Query { get; set; }

    public string? AttachQueryResult { get; set; }

    public string? NameofFile { get; set; }

    public string CallSource { get; set; } = null!;

    public string? BodyFormat { get; set; }

    public string? Importance { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderAttachment
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int? OrderNoteId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? FileSize { get; set; }

    public string? FileName { get; set; }
}

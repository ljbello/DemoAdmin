using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderLineArtworkRequest
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int OrderLineId { get; set; }

    public Guid ThumbnailId { get; set; }

    public string SectionName { get; set; } = null!;

    public string RevisionNotes { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public Guid RequestId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerReviewPhoto
{
    public int Id { get; set; }

    public int EntryId { get; set; }

    public string ImageName { get; set; } = null!;

    public DateTime UploadDate { get; set; }

    public virtual BvfeedEntry Entry { get; set; } = null!;
}

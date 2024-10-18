using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerUsedUpload
{
    public long CustomerUsedUploadId { get; set; }

    public string ImageName { get; set; } = null!;

    public long? OrderLineId { get; set; }

    public long? SavedProjectId { get; set; }

    public DateTime CreatedOn { get; set; }
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PersonalizeImageUpload
{
    public int UploadId { get; set; }

    public Guid CustomerArtworkId { get; set; }

    public int ImageTypeId { get; set; }

    public string ImageName { get; set; } = null!;

    public DateTime DateUploaded { get; set; }

    public bool? InUse { get; set; }

    public DateTime? LastProcessDate { get; set; }

    public bool Visible { get; set; }
}

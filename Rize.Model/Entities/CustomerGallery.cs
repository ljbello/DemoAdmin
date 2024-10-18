using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CustomerGallery
{
    public int Id { get; set; }

    public Guid CustomerLoginId { get; set; }

    public Guid CustomerArtworkGuidId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual CustomerLogin CustomerLogin { get; set; } = null!;
}

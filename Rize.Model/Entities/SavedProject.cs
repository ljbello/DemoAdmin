using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SavedProject
{
    public int Id { get; set; }

    public Guid CustomerLoginId { get; set; }

    public string ProjectName { get; set; } = null!;

    public string ProjectXml { get; set; } = null!;

    public int ProductId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public Guid? ThumbnailId { get; set; }

    public int PreviewVersion { get; set; }

    public bool? IsSample { get; set; }

    public bool Deleted { get; set; }

    public virtual CustomerLogin CustomerLogin { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductSetupAudit
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string VersionData { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TblUser CreatedByNavigation { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}

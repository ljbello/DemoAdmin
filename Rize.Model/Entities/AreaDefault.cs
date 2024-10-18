using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AreaDefault
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int? AreaNameId { get; set; }

    public string? PreviewGroup { get; set; }

    public string? FontName { get; set; }

    public int? FontSize { get; set; }

    public string? FontColor { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public virtual AreaName? AreaName { get; set; }
}

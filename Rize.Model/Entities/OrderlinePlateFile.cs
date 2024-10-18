using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderlinePlateFile
{
    public int OrderLinePlateFileId { get; set; }

    public int OrderlineId { get; set; }

    public string FileName { get; set; } = null!;

    public string SectionName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public double PreviewMatch { get; set; }
}

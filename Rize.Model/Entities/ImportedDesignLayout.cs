using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ImportedDesignLayout
{
    public int Id { get; set; }

    public int DesignId { get; set; }

    public int NewLayoutId { get; set; }
}

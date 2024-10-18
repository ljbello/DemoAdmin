using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderMailedSample
{
    public int OrdMaiSamOrderMailedSampleId { get; set; }

    public int OrdOrderId { get; set; }

    public DateTime OrdMaiSamDateCreated { get; set; }

    public virtual Order OrdOrder { get; set; } = null!;
}

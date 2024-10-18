using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AlertMain
{
    public int AlertMainId { get; set; }

    public string AlertName { get; set; } = null!;

    public string AlertCode { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime InsertDate { get; set; }
}

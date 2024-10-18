using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PackingSlip
{
    public int Id { get; set; }

    public int OrdOrderId { get; set; }

    public string PackingSlipXml { get; set; } = null!;

    public bool IsCreated { get; set; }

    public string? PlateErrorMessage { get; set; }
}

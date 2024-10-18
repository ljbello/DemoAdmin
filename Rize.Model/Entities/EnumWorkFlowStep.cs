using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EnumWorkFlowStep
{
    public int WorkFlowStepId { get; set; }

    public string WorkFlowStepName { get; set; } = null!;

    public string? WorkFlowStepDescription { get; set; }
}

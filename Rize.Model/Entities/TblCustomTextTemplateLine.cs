using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomTextTemplateLine
{
    public int CusTexTemCustomTextTemplateId { get; set; }

    public int CusTexTemLinLineNumber { get; set; }

    public string? CusTexTemLinText { get; set; }

    public int CusTexTemLinCustomTextTemplateLineId { get; set; }

    public virtual TblCustomTextTemplate CusTexTemCustomTextTemplate { get; set; } = null!;
}

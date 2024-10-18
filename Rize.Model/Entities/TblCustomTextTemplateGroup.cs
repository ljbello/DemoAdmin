using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomTextTemplateGroup
{
    public int CusTexTemGroCustomTextTemplateGroupId { get; set; }

    public string CusTexTemGroDescription { get; set; } = null!;

    public int CusTexTemGroCustomTextTemplateGroupYear { get; set; }

    public virtual ICollection<TblCustomTextTemplate> CusTexTemCustomTextTemplates { get; set; } = new List<TblCustomTextTemplate>();
}

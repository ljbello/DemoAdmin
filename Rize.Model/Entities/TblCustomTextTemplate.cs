using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblCustomTextTemplate
{
    public int CusTexTemCustomTextTemplateId { get; set; }

    public string CusTexTemDescription { get; set; } = null!;

    public int AreAreaId { get; set; }

    public virtual TblArea AreArea { get; set; } = null!;

    public virtual ICollection<TblCustomTextTemplateLine> TblCustomTextTemplateLines { get; set; } = new List<TblCustomTextTemplateLine>();

    public virtual ICollection<TblCustomTextTemplateGroup> CusTexTemGroCustomTextTemplateGroups { get; set; } = new List<TblCustomTextTemplateGroup>();
}

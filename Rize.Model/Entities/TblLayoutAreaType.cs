using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblLayoutAreaType
{
    public int LayAreTypLayoutAreaTypeId { get; set; }

    public string LayAreTypTypeName { get; set; } = null!;

    public virtual ICollection<TblLayoutArea> TblLayoutAreas { get; set; } = new List<TblLayoutArea>();

    public virtual ICollection<TblSuggestedWording> TblSuggestedWordings { get; set; } = new List<TblSuggestedWording>();
}

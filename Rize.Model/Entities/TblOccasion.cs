using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOccasion
{
    public int OccOccasionId { get; set; }

    public string OccDescription { get; set; } = null!;

    public virtual ICollection<TblSuggestedWording> SugWorSuggestedWordings { get; set; } = new List<TblSuggestedWording>();

    public virtual ICollection<TblVerseGroup> VerGroVerseGroups { get; set; } = new List<TblVerseGroup>();
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblVerseGroup
{
    public int VerGroVerseGroupId { get; set; }

    public string VerGroDescription { get; set; } = null!;

    public int VerGroVerseGroupYear { get; set; }

    public string? FriendlyName { get; set; }

    public int? PreviewVersion { get; set; }

    public int? ParentId { get; set; }

    public bool AvailableInPv3 { get; set; }

    public virtual ICollection<TblOccasion> OccOccasions { get; set; } = new List<TblOccasion>();

    public virtual ICollection<TblVerse> VerVerses { get; set; } = new List<TblVerse>();
}

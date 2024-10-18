using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblVerse
{
    public int VerVerseId { get; set; }

    public string? VerVerseNumber { get; set; }

    public int ProTypProductTypeId { get; set; }

    public int VerVerseYear { get; set; }

    public string? VerNotes { get; set; }

    public string? VerHorizontalVerseText { get; set; }

    public string? VerVerticalVerseText { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public int ModifiedBy { get; set; }

    public virtual TblUser ModifiedByNavigation { get; set; } = null!;

    public virtual ProductType ProTypProductType { get; set; } = null!;

    public virtual ICollection<TblAlbum> AlbAlbums { get; set; } = new List<TblAlbum>();

    public virtual ICollection<TblVerseGroup> VerGroVerseGroups { get; set; } = new List<TblVerseGroup>();
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblAlbum
{
    public int AlbAlbumId { get; set; }

    public int SupSupplierId { get; set; }

    public string? AlbName { get; set; }

    public string AlbAbbreviation { get; set; } = null!;

    public int AlbAlbumYear { get; set; }

    public string AlbTypeTemp { get; set; } = null!;

    public string? AlbCarlsonCraftAlbumOrderCode { get; set; }

    public virtual TblSupplier SupSupplier { get; set; } = null!;

    public virtual ICollection<TblVerse> VerVerses { get; set; } = new List<TblVerse>();
}

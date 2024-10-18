using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CardSizeSizeMapping
{
    public int CardSizeSizeMappingId { get; set; }

    public int CardSizeId { get; set; }

    public int SizeId { get; set; }

    public virtual CardSize CardSize { get; set; } = null!;

    public virtual TblSize Size { get; set; } = null!;
}

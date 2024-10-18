using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblTypestyle
{
    public int TypTypestyleId { get; set; }

    public string TypTypestyleCode { get; set; } = null!;

    public string? TypTypestyleName { get; set; }

    public int ProTypProductTypeId { get; set; }

    public string TypTypestyleStyle { get; set; } = null!;

    public string TypWindowsFontName { get; set; } = null!;

    public string TypDisplayName { get; set; } = null!;

    public bool? TypPreviewEnabled { get; set; }

    public int TypSizeOffset { get; set; }

    public bool TypRestrictCaps { get; set; }

    public int? GroupId { get; set; }

    public bool? Pv4enabled { get; set; }

    public string? SubtituteName { get; set; }

    public bool Pdfenable { get; set; }

    public string? Psname { get; set; }

    public string? FileName { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int ModifiedBy { get; set; }

    public virtual FontGroup? Group { get; set; }

    public virtual ProductType ProTypProductType { get; set; } = null!;

    public virtual ICollection<StoreFont> StoreFonts { get; set; } = new List<StoreFont>();

    public virtual ICollection<TblChristmasCardsOrderLineCustomText> TblChristmasCardsOrderLineCustomTexts { get; set; } = new List<TblChristmasCardsOrderLineCustomText>();

    public virtual ICollection<TblTypestyleGroup> TypGroTypestyleGroups { get; set; } = new List<TblTypestyleGroup>();
}

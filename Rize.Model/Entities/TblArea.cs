using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblArea
{
    public int AreAreaId { get; set; }

    public string AreDescription { get; set; } = null!;

    public string? AreCXmlAreaId { get; set; }

    public string? AreIcsmAreaInfoName { get; set; }

    public virtual ICollection<TblChristmasCardsOrderLineCustomText> TblChristmasCardsOrderLineCustomTexts { get; set; } = new List<TblChristmasCardsOrderLineCustomText>();

    public virtual ICollection<TblCustomTextTemplate> TblCustomTextTemplates { get; set; } = new List<TblCustomTextTemplate>();

    public virtual ICollection<TblOrderLineGraphic> TblOrderLineGraphics { get; set; } = new List<TblOrderLineGraphic>();

    public virtual ICollection<TblOrderLineSubmissionGraphicFile> TblOrderLineSubmissionGraphicFiles { get; set; } = new List<TblOrderLineSubmissionGraphicFile>();

    public virtual ICollection<TblPrintItem> PriItePrintItems { get; set; } = new List<TblPrintItem>();
}

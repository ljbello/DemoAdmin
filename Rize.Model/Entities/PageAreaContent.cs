using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class PageAreaContent
{
    public int Id { get; set; }

    public int ContentType { get; set; }

    public string PageContentId { get; set; } = null!;

    public int SiteId { get; set; }

    public string Area { get; set; } = null!;

    public int CurrentState { get; set; }

    public bool Active { get; set; }

    public DateTime Date { get; set; }

    public string Content { get; set; } = null!;

    public bool Display { get; set; }
}

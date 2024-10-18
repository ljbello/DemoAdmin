using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CmscontentAreaAudit
{
    public long CmscontentAreaAuditId { get; set; }

    public int? ContentAreaId { get; set; }

    public string? Name { get; set; }

    public string? HtmlContent { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public int? PageId { get; set; }

    public int? Position { get; set; }

    public bool? IsVisible { get; set; }

    public DateTime AuditInsertDateTime { get; set; }

    public string AuditActivity { get; set; } = null!;

    public int? PageVersion { get; set; }
}

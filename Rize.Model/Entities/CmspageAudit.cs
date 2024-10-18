using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CmspageAudit
{
    public int CmspageAuditId { get; set; }

    public int? PageId { get; set; }

    public string? PageUrl { get; set; }

    public string? MetaDescription { get; set; }

    public string? HeadingTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaHeader { get; set; }

    public string? MetaTitle { get; set; }

    public bool? Active { get; set; }

    public int? StoreId { get; set; }

    public bool? ShowInSiteMap { get; set; }

    public string? PageAliasUrl { get; set; }

    public int? PageTypeId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime AuditInsertDateTime { get; set; }

    public string AuditActivity { get; set; } = null!;

    public int? TemplateId { get; set; }

    public int? Version { get; set; }
}

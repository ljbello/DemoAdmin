using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SupplierStatusDashboard
{
    public Guid SupplierStatusDashboardId { get; set; }

    public DateTime RunDate { get; set; }

    public int SupplierId { get; set; }

    public int? OrderId { get; set; }

    public bool InvoiceRecords { get; set; }

    public int TotalReadCount { get; set; }

    public int TotalErrorsCount { get; set; }

    public int ProcessingErrorCount { get; set; }

    public int TotalCount { get; set; }

    public int DiscardedCount { get; set; }

    public int AcceptedCount { get; set; }

    public int BadOrderNumberCount { get; set; }

    public int BadOrderCount { get; set; }

    public int BadOrderPartCount { get; set; }

    public int BadOrderLineCount { get; set; }

    public bool ErrorsReportGenerated { get; set; }

    public string FileName { get; set; } = null!;

    public string? Notes { get; set; }
}

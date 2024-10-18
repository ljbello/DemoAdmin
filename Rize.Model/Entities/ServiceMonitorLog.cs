using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ServiceMonitorLog
{
    public int Id { get; set; }

    public string AppName { get; set; } = null!;

    public string Result { get; set; } = null!;

    public string? EmailBody { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailTo { get; set; }

    public bool Notified { get; set; }

    public string MonitoringAppName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}

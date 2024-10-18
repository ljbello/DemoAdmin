using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ExactTargetEmailType
{
    public int EmailTypeId { get; set; }

    public string Title { get; set; } = null!;

    public int Priority { get; set; }

    public string TriggerSendKey { get; set; } = null!;

    public string EmailLookUpId { get; set; } = null!;

    public int SendType { get; set; }

    public virtual ICollection<ExactTargetEmail> ExactTargetEmails { get; set; } = new List<ExactTargetEmail>();
}

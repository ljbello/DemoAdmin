using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class SaveProjectReminder
{
    public int Id { get; set; }

    public Guid CustomerLoginId { get; set; }

    public DateTime CreatedOn { get; set; }
}

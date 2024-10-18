using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminPagePanel
{
    public int Id { get; set; }

    public int PageId { get; set; }

    public int PanelId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual AdminPage Page { get; set; } = null!;

    public virtual AdminPanel Panel { get; set; } = null!;
}

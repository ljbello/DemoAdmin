using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class CmspageTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string IconUrl { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<Cmspage> Cmspages { get; set; } = new List<Cmspage>();
}

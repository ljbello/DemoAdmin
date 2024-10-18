using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ColorGroup
{
    public int Id { get; set; }

    public string FriendlyName { get; set; } = null!;

    public int ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    public virtual ICollection<ColorGroupColor> ColorGroupColors { get; set; } = new List<ColorGroupColor>();

    public virtual TblUser ModifiedByNavigation { get; set; } = null!;
}

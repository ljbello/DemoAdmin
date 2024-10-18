using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AdminShortcut
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public byte TypeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual TblUser User { get; set; } = null!;
}

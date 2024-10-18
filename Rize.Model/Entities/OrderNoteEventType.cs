using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class OrderNoteEventType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual ICollection<OrderNote> OrderNotes { get; set; } = new List<OrderNote>();
}

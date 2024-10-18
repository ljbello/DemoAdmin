using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmailSentQueue
{
    public int Id { get; set; }

    public Guid EmailId { get; set; }

    public int EmailTypeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual EmailType EmailType { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblOrderLineSubmission
{
    public int Id { get; set; }

    public int OrdLinOrderLineId { get; set; }

    public int ParOrderPartId { get; set; }

    public DateTime OrdLinSubDateCreated { get; set; }
}

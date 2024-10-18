using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProspectDoNotMail
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Company { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }
}

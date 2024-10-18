using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class DomoIpexclusion
{
    public string? Ipaddress { get; set; }

    public string? Description { get; set; }

    public bool WildCard { get; set; }
}

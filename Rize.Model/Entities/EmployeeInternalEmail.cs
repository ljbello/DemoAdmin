using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class EmployeeInternalEmail
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;
}

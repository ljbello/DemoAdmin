using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class GetFoldSpecification
{
    public int Productid { get; set; }

    public string FoldSpecifier { get; set; } = null!;

    public int Storeid { get; set; }
}

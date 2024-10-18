using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblProductSimilarProductCode
{
    public int ProSimProCodProductSimilarProductCodeId { get; set; }

    public int ProProductId { get; set; }

    public string SimProCodSimilarProductCode { get; set; } = null!;

    public virtual TblProduct ProProduct { get; set; } = null!;
}

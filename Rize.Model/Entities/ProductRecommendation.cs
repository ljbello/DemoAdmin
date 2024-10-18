using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class ProductRecommendation
{
    public long ProductRecommendationId { get; set; }

    public int ProductId { get; set; }

    public int RecommendedFor { get; set; }

    public int StoreId { get; set; }

    public DateTime? CreatedOn { get; set; }
}

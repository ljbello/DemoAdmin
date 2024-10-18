using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class TblBasketItem
{
    public int BasIteBasketItemId { get; set; }

    public int? BasBasketId { get; set; }

    public virtual TblBasket? BasBasket { get; set; }
}

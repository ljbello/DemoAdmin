using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class StorePayment
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int PaymentTypeId { get; set; }

    public bool IsCustomer { get; set; }

    public virtual TblOrderPaymentMethod PaymentType { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}

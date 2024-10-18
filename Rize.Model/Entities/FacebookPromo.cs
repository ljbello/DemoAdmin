using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class FacebookPromo
{
    public int Id { get; set; }

    public string Token { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Address2 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string? Company { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string SelectedProduct { get; set; } = null!;

    public DateTime? FulfilledDate { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

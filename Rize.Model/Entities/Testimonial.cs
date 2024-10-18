using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class Testimonial
{
    public int Id { get; set; }

    public string TestimonialText { get; set; } = null!;

    public string? ByName { get; set; }

    public string? ByLocation { get; set; }

    public bool Active { get; set; }

    public int StoreId { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CustomerPhotoPath { get; set; }

    public string? QuoteType { get; set; }
}

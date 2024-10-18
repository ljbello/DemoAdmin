using System;
using System.Collections.Generic;

namespace Rize.Model.Entities;

public partial class AssortmentPack
{
    public int ProductId { get; set; }

    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string PageName { get; set; } = null!;

    public int CardsInPack { get; set; }

    public int NumberOfDesigns { get; set; }

    public int NumberPerDesign { get; set; }

    public int EntityRank { get; set; }

    public DateTime EntityCreated { get; set; }

    public bool EntityInactive { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public virtual ICollection<AssortmentPackImage> AssortmentPackImages { get; set; } = new List<AssortmentPackImage>();

    public virtual TblDepartment Department { get; set; } = null!;

    public virtual TblProduct Product { get; set; } = null!;
}

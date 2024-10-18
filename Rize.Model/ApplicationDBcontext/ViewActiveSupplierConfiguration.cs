using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class ViewActiveSupplierConfiguration : IEntityTypeConfiguration<ViewActiveSupplier>
{
    public void Configure(EntityTypeBuilder<ViewActiveSupplier> entity)
    {
        entity
                .HasNoKey()
                .ToView("view_ActiveSuppliers");

        entity.Property(e => e.SupplierId).ValueGeneratedOnAdd();

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<ViewActiveSupplier> entity);
}

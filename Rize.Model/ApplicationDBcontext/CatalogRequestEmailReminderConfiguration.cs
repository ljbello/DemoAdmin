using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class CatalogRequestEmailReminderConfiguration : IEntityTypeConfiguration<CatalogRequestEmailReminder>
{
    public void Configure(EntityTypeBuilder<CatalogRequestEmailReminder> entity)
    {
        entity.ToTable("CatalogRequestEmailReminder");

        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<CatalogRequestEmailReminder> entity);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderNoteEventTypeConfiguration : IEntityTypeConfiguration<OrderNoteEventType>
{
    public void Configure(EntityTypeBuilder<OrderNoteEventType> entity)
    {
        entity.ToTable("OrderNoteEventType");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderNoteEventType> entity);
}

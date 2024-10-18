using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class OrderNoteConfiguration : IEntityTypeConfiguration<OrderNote>
{
    public void Configure(EntityTypeBuilder<OrderNote> entity)
    {
        entity.ToTable(tb => tb.HasTrigger("tr_OrderNotes_OrderLastUpdatedDate"));

        entity.HasIndex(e => e.OrderId, "OrderNotes_IX1");

        entity.HasIndex(e => e.CreatedOn, "OrderNotes_IX2");

        entity.HasIndex(e => e.OrderLineId, "OrderNotes_IX3");

        entity.HasIndex(e => new { e.EventTypeId, e.StatusId }, "OrderNotes_IX4");

        entity.HasIndex(e => new { e.UserId, e.OrderLineId }, "OrderNotes_IX5");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
        entity.Property(e => e.Notes).IsUnicode(false);
        entity.Property(e => e.OrderId).HasColumnName("OrderID");
        entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");
        entity.Property(e => e.StatusId).HasColumnName("StatusID");
        entity.Property(e => e.UserId).HasColumnName("UserID");

        entity.HasOne(d => d.EventType).WithMany(p => p.OrderNotes)
                .HasForeignKey(d => d.EventTypeId)
                .HasConstraintName("FK_OrderNotes_OrderNoteEventType");

        entity.HasOne(d => d.Order).WithMany(p => p.OrderNotes)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderNotes_Order");

        entity.HasOne(d => d.OrderLine).WithMany(p => p.OrderNotes)
                .HasForeignKey(d => d.OrderLineId)
                .HasConstraintName("FK_OrderNotes_tblOrderLines");

        entity.HasOne(d => d.User).WithMany(p => p.OrderNotes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderNotes_tblUsers");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<OrderNote> entity);
}

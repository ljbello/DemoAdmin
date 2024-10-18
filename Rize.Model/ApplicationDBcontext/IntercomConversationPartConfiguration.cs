using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class IntercomConversationPartConfiguration : IEntityTypeConfiguration<IntercomConversationPart>
{
    public void Configure(EntityTypeBuilder<IntercomConversationPart> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Intercom__3213E83F21F22FAE");

        entity.ToTable("IntercomConversationPart");

        entity.Property(e => e.Id)
                .HasMaxLength(200)
                .HasColumnName("id");
        entity.Property(e => e.Authorid)
                .HasMaxLength(50)
                .HasColumnName("authorid");
        entity.Property(e => e.Authortype)
                .HasMaxLength(50)
                .HasColumnName("authortype");
        entity.Property(e => e.Body).HasColumnName("body");
        entity.Property(e => e.Conversationid)
                .HasMaxLength(200)
                .HasColumnName("conversationid");
        entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.NotifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("notified_at");
        entity.Property(e => e.PartType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("part_type");
        entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<IntercomConversationPart> entity);
}

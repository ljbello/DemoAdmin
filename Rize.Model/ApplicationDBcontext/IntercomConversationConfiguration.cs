using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class IntercomConversationConfiguration : IEntityTypeConfiguration<IntercomConversation>
{
    public void Configure(EntityTypeBuilder<IntercomConversation> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__Intercom__3213E83FAC1067F0");

        entity.ToTable("IntercomConversation");

        entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("id");
        entity.Property(e => e.Assignee)
                .HasMaxLength(50)
                .HasColumnName("assignee");
        entity.Property(e => e.ConversionMessage).HasColumnName("conversion_message");
        entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
        entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        entity.Property(e => e.Open).HasColumnName("open");
        entity.Property(e => e.Read).HasColumnName("read");
        entity.Property(e => e.Tags)
                .HasMaxLength(100)
                .HasColumnName("tags");
        entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<IntercomConversation> entity);
}

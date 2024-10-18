using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailSentQueueConfiguration : IEntityTypeConfiguration<EmailSentQueue>
{
    public void Configure(EntityTypeBuilder<EmailSentQueue> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__EmailSen__3214EC072358AC97");

        entity.ToTable("EmailSentQueue");

        entity.HasIndex(e => e.EmailId, "EmailSentQueue_IX1");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

        entity.HasOne(d => d.EmailType).WithMany(p => p.EmailSentQueues)
                .HasForeignKey(d => d.EmailTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailSentQueue_EmailType");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailSentQueue> entity);
}

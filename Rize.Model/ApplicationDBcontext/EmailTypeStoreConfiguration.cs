using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailTypeStoreConfiguration : IEntityTypeConfiguration<EmailTypeStore>
{
    public void Configure(EntityTypeBuilder<EmailTypeStore> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__EmailTyp__3214EC07951CC45D");

        entity.ToTable("EmailTypeStore");

        entity.Property(e => e.Bcc)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.CreatedBy).HasDefaultValue(1);
        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.EmailHeading)
                .HasMaxLength(1000)
                .IsUnicode(false);
        entity.Property(e => e.EmailSubHeading)
                .HasMaxLength(1000)
                .IsUnicode(false);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.ReplyTo)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Sender)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.Subject)
                .HasMaxLength(1000)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EmailTypeStoreCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailTypeStore_CreatedBy");

        entity.HasOne(d => d.EmailType).WithMany(p => p.EmailTypeStores)
                .HasForeignKey(d => d.EmailTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailTypeStore_EmailType");

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.EmailTypeStoreModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_EmailTypeStore_ModifiedBy");

        entity.HasOne(d => d.Store).WithMany(p => p.EmailTypeStores)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailTypeStore_tblStores");

        entity.HasOne(d => d.Template).WithMany(p => p.EmailTypeStores)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailTypeStore_EmailTemplate");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailTypeStore> entity);
}

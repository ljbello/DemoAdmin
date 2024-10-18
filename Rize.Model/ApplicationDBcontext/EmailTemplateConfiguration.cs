using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailTemplateConfiguration : IEntityTypeConfiguration<EmailTemplate>
{
    public void Configure(EntityTypeBuilder<EmailTemplate> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__EmailTem__3214EC079B01C10C");

        entity.ToTable("EmailTemplate");

        entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.IsActive).HasDefaultValue(true);
        entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

        entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EmailTemplateCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.EmailTemplateModifiedByNavigations).HasForeignKey(d => d.ModifiedBy);

        entity.HasOne(d => d.Store).WithMany(p => p.EmailTemplates)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailTemplate_tblStores");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailTemplate> entity);
}

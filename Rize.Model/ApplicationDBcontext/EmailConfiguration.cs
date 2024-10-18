using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailConfiguration : IEntityTypeConfiguration<Email>
{
    public void Configure(EntityTypeBuilder<Email> entity)
    {
        entity.ToTable("Email");

        entity.Property(e => e.EmailId).HasColumnName("EmailID");
        entity.Property(e => e.AttachQueryResult)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength();
        entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasDefaultValue("");
        entity.Property(e => e.BodyFormat)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.CallSource)
                .HasMaxLength(100)
                .IsUnicode(false);
        entity.Property(e => e.EmailStatus)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("UnSent");
        entity.Property(e => e.Importance)
                .HasMaxLength(25)
                .IsUnicode(false);
        entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        entity.Property(e => e.NameofFile)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.Query).IsUnicode(false);
        entity.Property(e => e.Recipients)
                .HasMaxLength(500)
                .IsUnicode(false);
        entity.Property(e => e.Subject)
                .HasMaxLength(250)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Email> entity);
}

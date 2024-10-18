using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class TblSessionConfiguration : IEntityTypeConfiguration<TblSession>
{
    public void Configure(EntityTypeBuilder<TblSession> entity)
    {
        entity.HasKey(e => new { e.SessionGuid, e.Key });

        entity.ToTable("tblSessions");

        entity.Property(e => e.Key)
                .HasMaxLength(50)
                .IsUnicode(false);
        entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Date_Created");
        entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<TblSession> entity);
}

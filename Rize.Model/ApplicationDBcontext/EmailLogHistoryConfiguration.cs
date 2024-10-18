using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmailLogHistoryConfiguration : IEntityTypeConfiguration<EmailLogHistory>
{
    public void Configure(EntityTypeBuilder<EmailLogHistory> entity)
    {
        entity.HasKey(e => e.Id).HasName("PK__EmailLog__3214EC0742F91948");

        entity.ToTable("EmailLogHistory");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmailLogHistory> entity);
}

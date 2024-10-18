using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class EmployeeInternalEmailConfiguration : IEntityTypeConfiguration<EmployeeInternalEmail>
{
    public void Configure(EntityTypeBuilder<EmployeeInternalEmail> entity)
    {
        entity.ToTable("EmployeeInternalEmail");

        entity.HasIndex(e => e.Email, "UQ_EmployeeInternalEmail_Email").IsUnique();

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<EmployeeInternalEmail> entity);
}

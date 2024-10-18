using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class MissingPaymentConfiguration : IEntityTypeConfiguration<MissingPayment>
{
    public void Configure(EntityTypeBuilder<MissingPayment> entity)
    {
        entity.HasNoKey();

        entity.Property(e => e.Amount).HasColumnType("money");
        entity.Property(e => e.AvsrespCode)
                .HasMaxLength(255)
                .HasColumnName("AVSRespCode");
        entity.Property(e => e.CardNumber)
                .HasMaxLength(255)
                .HasColumnName("Card Number");
        entity.Property(e => e.CardType)
                .HasMaxLength(255)
                .HasColumnName("Card Type");
        entity.Property(e => e.CvvrespCode)
                .HasMaxLength(255)
                .HasColumnName("CVVRespCode");
        entity.Property(e => e.Date).HasColumnType("datetime");
        entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("NOTES");
        entity.Property(e => e.OrderNumber).HasMaxLength(255);
        entity.Property(e => e.RespCode)
                .HasMaxLength(255)
                .HasColumnName("Resp Code");
        entity.Property(e => e.TransType)
                .HasMaxLength(255)
                .HasColumnName("Trans Type");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<MissingPayment> entity);
}

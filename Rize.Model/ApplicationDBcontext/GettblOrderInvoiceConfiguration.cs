using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rize.Model.Entities;


namespace Rize.Model.ApplicationDBcontext.Configurations;

public partial class GettblOrderInvoiceConfiguration : IEntityTypeConfiguration<GettblOrderInvoice>
{
    public void Configure(EntityTypeBuilder<GettblOrderInvoice> entity)
    {
        entity
                .HasNoKey()
                .ToView("GettblOrderInvoices");

        entity.Property(e => e.OrdInvInvoiceShipping)
                .HasColumnType("money")
                .HasColumnName("OrdInv__InvoiceShipping");
        entity.Property(e => e.OrdInvInvoiceSubTotal)
                .HasColumnType("money")
                .HasColumnName("OrdInv__InvoiceSubTotal");
        entity.Property(e => e.OrdOrderid).HasColumnName("ord__orderid");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<GettblOrderInvoice> entity);
}

using InvoiceSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.Data.Configurations
{
    public partial class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> entity)
        {
            entity.HasKey(e => e.ItemId);

            entity.Property(e => e.ItemId).ValueGeneratedNever();

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceItems);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<InvoiceItem> entity);
    }
}

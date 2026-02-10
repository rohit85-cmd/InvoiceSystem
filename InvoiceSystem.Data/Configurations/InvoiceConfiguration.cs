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
    public partial class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> entity)
        {
            entity.HasKey(e => e.InvoiceId);

            entity.Property(e => e.InvoiceId).ValueGeneratedNever();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Invoice> entity);
    }
}

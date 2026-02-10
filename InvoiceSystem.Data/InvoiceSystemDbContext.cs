using InvoiceSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.Data
{
    public partial class InvoiceSystemDbContext : DbContext
    {
        public InvoiceSystemDbContext(DbContextOptions<InvoiceSystemDbContext> options) : base(options) { }

        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.InvoiceItemConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

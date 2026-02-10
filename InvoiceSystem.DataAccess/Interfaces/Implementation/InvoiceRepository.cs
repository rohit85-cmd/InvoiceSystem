using InvoiceSystem.Data;
using InvoiceSystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.DataAccess.Interfaces.Implementation
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly InvoiceSystemDbContext dbContext;
        public InvoiceRepository(InvoiceSystemDbContext dbcontext)
        {
            this.dbContext = dbcontext;
        }

        public async Task<List<InvoiceItem>> GetAllInvoiceItems()
        {
            return await this.dbContext.InvoiceItems.ToListAsync();
        }

    }
}

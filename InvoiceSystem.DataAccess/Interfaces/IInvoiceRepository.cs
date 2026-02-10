using InvoiceSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.DataAccess.Interfaces
{
    public interface IInvoiceRepository
    {
        public Task<List<InvoiceItem>> GetAllInvoiceItems();
    }
}

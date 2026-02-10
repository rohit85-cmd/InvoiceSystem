using InvoiceSystem.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.Business.Services
{
    public interface IInvoiceService
    {
        public Task<List<InvoiceItemsDto>> GetAllInvoices();
    }
}

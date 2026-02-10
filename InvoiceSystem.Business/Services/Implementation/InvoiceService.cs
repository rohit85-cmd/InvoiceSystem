using InvoiceSystem.Business.Dto;
using InvoiceSystem.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.Business.Services.Implementation
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }

        public async Task<List<InvoiceItemsDto>> GetAllInvoices()
        {
            var items = await this.invoiceRepository.GetAllInvoiceItems();
            return items.Select(a => new InvoiceItemsDto()
            {
                ItemID = a.ItemId,
                Price = a.Price,
                Name = a.Name
            }).ToList();
        }

    }
}

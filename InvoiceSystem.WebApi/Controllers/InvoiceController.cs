using InvoiceSystem.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceSystem.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly ILogger<InvoiceController> _logger;
        private readonly IInvoiceService invoiceService;

        public InvoiceController(ILogger<InvoiceController> logger, IInvoiceService invoiceService)
        {
            this._logger = logger;
            this.invoiceService = invoiceService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            this._logger.LogInformation("Get Invoice Started");
            return Ok(await this.invoiceService.GetAllInvoices());
        }
    }
}

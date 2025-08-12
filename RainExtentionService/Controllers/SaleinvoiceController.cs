using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Service;

namespace RainExtentionService.Controllers
{
 
        [ApiController]
        [Route("api/[controller]")]
        public class SaleInvoiceController : ControllerBase
        {
            private readonly SaleInvoiceService _invoiceService;

            public SaleInvoiceController(SaleInvoiceService invoiceService)
            {
                _invoiceService = invoiceService;
            }

            [HttpGet("{invoiceId}")]
            public async Task<IActionResult> GetInvoice(Guid invoiceId)
            {
                var invoice = await _invoiceService.GetInvoiceByIdAsync(invoiceId);
                if (invoice == null)
                    return NotFound();

                return Ok(invoice);
            }
        }

   
}

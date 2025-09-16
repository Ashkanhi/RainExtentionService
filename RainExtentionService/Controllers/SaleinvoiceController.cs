using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Service;
using RainExtention.Domain.Entities;


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

        // POST: api/SaleInvoice
        [HttpPost("SaveInvoice")] // 👈 مسیر دقیق متد
        public async Task<IActionResult> AddSaleInvoice([FromBody] SaleInvoiceDto invoice)
        {
            if (invoice == null)
                return BadRequest("Invoice data is required.");

            try
            {

                var response = await _invoiceService.AddAsync(invoice);
                return Ok(response); // خودش به JSON تبدیل می‌شه
                //await _invoiceService.AddAsync(invoice); // 👈 این متد همون AddAsync شماست
                //return Ok(new { Message = "Invoice added successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error saving invoice", Details = ex.Message });
            }
        }

    }

   
}

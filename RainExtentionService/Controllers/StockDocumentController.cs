using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Interface;
using RainExtention.Domain.Entities;

namespace RainExtentionService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockDocumentsController : ControllerBase
    {
        private readonly IStockDocumentService _stockDocumentService;

        public StockDocumentsController(IStockDocumentService stockDocumentService)
        {
            _stockDocumentService = stockDocumentService;
        }

        /// <summary>
        /// دریافت سند انبار بر اساس شناسه
        /// </summary>
        /// <param name="id">شناسه سند (DocumentId)</param>
        /// <returns>سند انبار یا 404 در صورت عدم وجود</returns>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<StockDocument?>> GetById(Guid id)
        {
            try
            {
                var document = await _stockDocumentService.GetByIdAsync(id);

                if (document == null)
                {
                    return NotFound(new { Message = "سند مورد نظر یافت نشد." });
                }

                return Ok(document);
            }
            catch (Exception ex)
            {
                // در محیط تولید، از Logging استفاده کنید
                return StatusCode(500, new { Message = "خطای داخلی سرور", Error = ex.Message });
            }
        }
    }
}

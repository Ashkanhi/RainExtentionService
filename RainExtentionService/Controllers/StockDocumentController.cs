using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Interface;
<<<<<<< HEAD
using RainExtention.Domain.Entities;

namespace RainExtentionService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockDocumentsController : ControllerBase
    {
        private readonly IStockDocumentService _stockDocumentService;

        public StockDocumentsController(IStockDocumentService stockDocumentService)
=======

namespace RainExtentionService.Controllers
{
    public class StockDocumentController : Controller
    {
        private readonly IStockDocumentService _stockDocumentService;

        public StockDocumentController(IStockDocumentService stockDocumentService)
>>>>>>> b36b978a492612164d693f5b6ab6102bf691ddba
        {
            _stockDocumentService = stockDocumentService;
        }

<<<<<<< HEAD
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
=======
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var document = await _stockDocumentService.GetStockDocumentByIdAsync(id);

            if (document == null)
                return NotFound();

            return Ok(document);
        }
        public IActionResult Index()
        {
            return View();
>>>>>>> b36b978a492612164d693f5b6ab6102bf691ddba
        }
    }
}

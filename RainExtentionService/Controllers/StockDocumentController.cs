using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Interface;

namespace RainExtentionService.Controllers
{
    public class StockDocumentController : Controller
    {
        private readonly IStockDocumentService _stockDocumentService;

        public StockDocumentController(IStockDocumentService stockDocumentService)
        {
            _stockDocumentService = stockDocumentService;
        }

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
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Service;
using RainExtention.Domain.Entities;
using System.Text.Json;
using System.IO;
using System;

namespace RainExtentionService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SaleInvoiceController : ControllerBase
    {

        private readonly SaleInvoiceService _invoiceService;
        private readonly IWebHostEnvironment _environment;

        public SaleInvoiceController(IWebHostEnvironment environment, SaleInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
            _environment = environment;
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
                // ابتدا فاکتور را ثبت کنید
                var response = await _invoiceService.AddAsync(invoice);

                // سریالایز کردن response (یا invoice اگر تغییر کرده) به JSON
                string jsonContent = JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true });

                // ایجاد مسیر فایل (مثلاً در wwwroot/invoices)
                var environment = _environment; // فرض کنید IWebHostEnvironment را inject کرده‌اید
                string invoicesFolder = Path.Combine(environment.WebRootPath, "invoices");
                Directory.CreateDirectory(invoicesFolder); // ایجاد فولدر اگر وجود نداشته باشد

                // نام فایل با timestamp برای منحصربه‌فرد بودن
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                string fileName = $"invoice_{timestamp}.json";
                string filePath = Path.Combine(invoicesFolder, fileName);

                // نوشتن JSON در فایل
                await System.IO.File.WriteAllTextAsync(filePath, jsonContent);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error saving invoice", Details = ex.Message });
            }
        }

    }
    }

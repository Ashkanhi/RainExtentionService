using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Interface;
using RainExtention.Domain.Entities;
using RainExtention.Application.Models;


namespace RainExtention.Application.Service
{
    public class SaleInvoiceService
    {
        private readonly ISaleInvoiceRepository _repository;

        public SaleInvoiceService(ISaleInvoiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<SaleInvoiceDto?> GetInvoiceByIdAsync(Guid invoiceId)
        {
            return await _repository.GetByIdAsync(invoiceId);
        }


        public async Task<AddSaleInvoiceResponse> AddAsync(SaleInvoiceDto invoice)
        {

            // تولید شماره فاکتور
            var lastNumber = await _repository.GetLastInvoiceNumberAsync(invoice.BookerStoreId);
            invoice.InvoiceNumber = GenerateNextInvoiceNumber(lastNumber, invoice.BookerStoreId, 1);
            invoice.InvoiceId = Guid.NewGuid(); 

            // ذخیره
            await _repository.AddAsync(invoice);

            // برگرداندن پاسخ ساختاریافته
            return new AddSaleInvoiceResponse
            {
                InvoiceId = invoice.InvoiceId,
                InvoiceNumber = invoice.InvoiceNumber,
                Message = "Invoice added successfully."
            };
        }
        private string GenerateNextInvoiceNumber(string? lastNumber, int storeId, int workstationId)
        {
            const long defaultStart = 1; // اگر هیچ فاکتوری نبود
            long nextSerial = defaultStart;

            if (!string.IsNullOrEmpty(lastNumber))
            {
                var parts = lastNumber.Split('-');
                if (parts.Length == 3 && long.TryParse(parts[2], out long currentSerial))
                {
                    nextSerial = currentSerial + 1;
                }
                else
                {
                    nextSerial = defaultStart;
                }
            }
            else
            {
                nextSerial = defaultStart;
            }

            return $"{storeId}-{workstationId}-{nextSerial}";
        }

    }
}

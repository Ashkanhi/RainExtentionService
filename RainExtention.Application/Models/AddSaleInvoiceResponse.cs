using RainExtention.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Application.Models
{
    public class AddSaleInvoiceResponse
    {
        public Guid InvoiceId { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public string Message { get; set; } = "Invoice added successfully.";

        // ✅ اضافه شده: کل اطلاعات فاکتور نهایی
        public SaleInvoiceDto InvoiceData { get; set; }

        // می‌تونی بعداً فیلدهای دیگه اضافه کنی
        // public DateTime InvoiceDate { get; set; }
        // public decimal TotalAmount { get; set; }
    }
}

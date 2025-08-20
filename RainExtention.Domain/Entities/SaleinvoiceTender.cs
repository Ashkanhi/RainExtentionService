using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Entities
{
    public partial  class SaleInvoiceTender
    {
        // Properties (Primary Key represented by business meaning, not EF attributes)
        public int BookerStoreId { get; set; }
        public int BookerWorkstationId { get; set; }
        public Guid InvoiceId { get; set; }
        public int LineItemId { get; set; }

        // Payment details
        public int? TenderId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ReturnAmount { get; set; }
        public decimal? ExchangeAmount { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public Guid? CashierId { get; set; }

        // ارجاع به فاکتور (اختیاری می‌تونی داشته باشی یا نه)
        //  public SaleInvoice SaleInvoice { get; set; }
    }

}

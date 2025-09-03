using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Application.Commands
{
    public class Input_InvoiceTenderDto
    {

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
    }
}

using RainExtention.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace RainExtention.Application.Commands
{
    public class Input_InvoiceDto : IRequest<AddSaleInvoiceResponse>
    {
        public int BookerStoreId { get; set; }
        public int BookerWorkstationId { get; set; }
        public Guid InvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateOnly? BusinessDate { get; set; }
        public string? InvoiceNumber { get; set; }
        public int? InvoiceTypeId { get; set; }
        public Guid? CustomerId { get; set; }
        public decimal? ExpectedAmount { get; set; }
        public Guid? CreationUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid? AuthorizeUser { get; set; }
        public bool? IsOnlineSale { get; set; }
        public int? ScanCount { get; set; }
        public TimeOnly? InvoiceTime { get; set; }
        public int? SaleChannelId { get; set; }
        public Guid? StockId { get; set; }

        public string? CustomerCode { get; set; }

        // --- آیتم‌ها، پرداخت‌ها، تحویل ---
        public List<Input_InvoiceLineItemDto> Input_InvoiceLineItem_Dto { get; set; } = new();
        public List<Input_InvoiceTenderDto> Input_InvoiceTender_Dto { get; set; } = new();
        public List<Input_InvoiceItemDeliveryDto> Input_InvoiceItemDelivery_Dto { get; set; } = new();
    }
}

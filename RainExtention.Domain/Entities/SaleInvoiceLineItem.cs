using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Entities
{
    public partial class SaleInvoiceLineItem
    {

        public int BookerStoreId { get; set; }
        public int BookerWorkstationId { get; set; }
        public Guid InvoiceId { get; set; }
        public int LineItemId { get; set; }
        public Guid? ItemId { get; set; }
        public int? TypeId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? BonusQuantity { get; set; }
        public decimal? PriceAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? InvoiceDiscount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? InvoiceDiscountPercent { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TollAmount { get; set; }
        public decimal? RoundAmount { get; set; }
        public decimal? ExpectedAmount { get; set; }
        public decimal? ManufacturerPrice { get; set; }
        public bool? IsDelivery { get; set; }
        public int? ReasonId { get; set; }
        public decimal? SupplierDiscount { get; set; }
        public bool? IsPriceWithTax { get; set; }
        public bool? IsManualDiscount { get; set; }
        public decimal? ConsumerPrice { get; set; }
        public byte? RoundType { get; set; }
        public decimal? ManualDiscount { get; set; }
        public decimal? ManualDiscountPercent { get; set; }
        public decimal? Point { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? OrderQuantity { get; set; }
        public decimal? ServiceAmount { get; set; }
        public int? StatusId { get; set; }
        public bool? IsTaxAsDiscount { get; set; }
        public DateOnly? InvoiceDate { get; set; }



    }
}

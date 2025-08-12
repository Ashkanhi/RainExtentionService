using RainExtention.Domain.Interface;
using RainExtention.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Entities; // برای SaleInvoice
using Microsoft.EntityFrameworkCore; // برای Include

namespace RainExtention.Infrastructure.Repositories
{
    public class SaleInvoiceRepository : ISaleInvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        public SaleInvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SaleInvoice?> GetByIdAsync(Guid invoiceId)
        {
            var entity = await _context.SaleInvoices
                .Include(i => i.SaleInvoiceLineItems)
                .Include(i => i.SaleInvoiceTenders)
                .FirstOrDefaultAsync(i => i.InvoiceId == invoiceId);

            if (entity == null)
                return null;

            var domainModel = new SaleInvoice
            {
                BookerStoreId = entity.BookerStoreId,
                BookerWorkstationId = entity.BookerWorkstationId,
                InvoiceId = entity.InvoiceId,
                InvoiceDate = entity.InvoiceDate,
                BusinessDate = entity.BusinessDate,
                InvoiceNumber = entity.InvoiceNumber,
                InvoiceTypeId = entity.InvoiceTypeId,
                CustomerId = entity.CustomerId,
                ExpectedAmount = entity.ExpectedAmount,
                CreationUser = entity.CreationUser,
                CreationDate = entity.CreationDate,
                ModifyUser = entity.ModifyUser,
                ModifyDate = entity.ModifyDate,
                AuthorizeUser = entity.AuthorizeUser,
                IsOnlineSale = entity.IsOnlineSale,
                ScanCount = entity.ScanCount,
                InvoiceTime = entity.InvoiceTime,
                SaleChannelId = entity.SaleChannelId,
                StockId = entity.StockId,

                InvoiceLineItems = entity.SaleInvoiceLineItems?.Select(li => new SaleInvoiceLineItem
                {
                    BookerStoreId = li.BookerStoreId,
                    BookerWorkstationId = li.BookerWorkstationId,
                    InvoiceId = li.InvoiceId,
                    LineItemId = li.LineItemId,
                    ItemId = li.ItemId,
                    TypeId = li.TypeId,
                    Quantity = li.Quantity,
                    BonusQuantity = li.BonusQuantity,
                    PriceAmount = li.PriceAmount,
                    DiscountAmount = li.DiscountAmount,
                    InvoiceDiscount = li.InvoiceDiscount,
                    DiscountPercent = li.DiscountPercent,
                    InvoiceDiscountPercent = li.InvoiceDiscountPercent,
                    TaxAmount = li.TaxAmount,
                    TollAmount = li.TollAmount,
                    RoundAmount = li.RoundAmount,
                    ExpectedAmount = li.ExpectedAmount,
                    ManufacturerPrice = li.ManufacturerPrice,
                    IsDelivery = li.IsDelivery,
                    ReasonId = li.ReasonId,
                    SupplierDiscount = li.SupplierDiscount,
                    IsPriceWithTax = li.IsPriceWithTax,
                    IsManualDiscount = li.IsManualDiscount,
                    ConsumerPrice = li.ConsumerPrice,
                    RoundType = li.RoundType,
                    ManualDiscount = li.ManualDiscount,
                    ManualDiscountPercent = li.ManualDiscountPercent,
                    Point = li.Point,
                    CurrentPrice = li.CurrentPrice,
                    OrderQuantity = li.OrderQuantity,
                    ServiceAmount = li.ServiceAmount,
                    StatusId = li.StatusId,
                    IsTaxAsDiscount = li.IsTaxAsDiscount,
                    InvoiceDate = li.InvoiceDate
                }).ToList() ?? new(),

                InvoiceTenders = entity.SaleInvoiceTenders?.Select(t => new SaleInvoiceTender
                {
                    BookerStoreId = t.BookerStoreId ,
                   BookerWorkstationId = t.BookerWorkstationId ,
                    InvoiceId = t.InvoiceId,
                    TenderId = t.TenderId,
                    Amount = t.Amount,
                    CashierId = t.CashierId ,
                    LineItemId = t.LineItemId , 
                    DueDate =  t.DueDate, 
                    PaymentDate = t.PaymentDate ,
                    ExchangeAmount = t.ExchangeAmount , 
                    ReturnAmount = t.ReturnAmount
                }).ToList() ?? new()
            };

            return domainModel;
        }

    }

   
 

    }

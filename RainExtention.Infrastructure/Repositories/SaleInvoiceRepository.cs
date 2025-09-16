using RainExtention.Domain.Interface;
using RainExtention.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Entities; // برای SaleInvoice
using Microsoft.EntityFrameworkCore;
using System.CodeDom.Compiler; // برای Include

namespace RainExtention.Infrastructure.Repositories
{
    public class SaleInvoiceRepository : ISaleInvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        public SaleInvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string?> GetLastInvoiceNumberAsync(int bookerStoreId)
        {
            return await _context.SaleInvoices
                .Where(i =>
                    i.BookerStoreId == bookerStoreId &&
                    i.BookerWorkstationId == 1 && 
                    i.InvoiceTypeId == 350
                    )   
                .OrderByDescending(i => i.InvoiceNumber)  
                .ThenByDescending(i => i.InvoiceDate) 
                .Select(i => i.InvoiceNumber)
                .FirstOrDefaultAsync(); // اگر نباشه null برمی‌گردونه
        }

        public async Task AddAsync(Domain.Entities.SaleInvoiceDto invoice)
        {
            // ✅ 1. تولید مقادیر سروری
            var generateInvoiceId = invoice.InvoiceId;
            var generateNow = DateTime.Now; ; 
            var generateDateOnly = DateOnly.FromDateTime(generateNow);
            var generateTimeOnly = TimeOnly.FromDateTime(generateNow);
            var generateinvoiceTypeID = 350;
            var generateBookerWorkstation = 1; 

            // ✅ 3. مپ به موجودیت زیرساخت
            var efEntity = new Infrastructure.Entities.SaleInvoice
            {
                // --- اطلاعات فاکتور ---
                BookerStoreId = invoice.BookerStoreId,
                BookerWorkstationId = generateBookerWorkstation ,
                InvoiceId = generateInvoiceId,
                InvoiceNumber = invoice.InvoiceNumber ,   // ✅ همیشه شماره ما
                InvoiceDate = generateNow,
                BusinessDate = generateDateOnly,
                InvoiceTypeId = generateinvoiceTypeID,
                CustomerId = invoice.CustomerId,
                ExpectedAmount = invoice.ExpectedAmount,
                CreationUser = invoice.CreationUser,
                CreationDate = generateNow,
                ModifyUser = invoice.CreationUser,
                ModifyDate = generateNow,
                AuthorizeUser = invoice.CreationUser,
                IsOnlineSale = true,
                ScanCount = null,
                InvoiceTime = generateTimeOnly,
                SaleChannelId = invoice.SaleChannelId,
                StockId = invoice.StockId,

                // --- آیتم‌های فاکتور ---
                SaleInvoiceLineItems = invoice.InvoiceLineItems?.Select(li => new Infrastructure.Entities.SaleInvoiceLineItem
                {
                    BookerStoreId = li.BookerStoreId,
                    BookerWorkstationId = generateBookerWorkstation,
                    InvoiceId = generateInvoiceId,
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
                    ManufacturerPrice = 0,
                    IsDelivery = li.IsDelivery,
                    ReasonId = li.ReasonId,
                    SupplierDiscount = null,
                    IsPriceWithTax = li.IsPriceWithTax,
                    IsManualDiscount = li.IsManualDiscount,
                    ConsumerPrice = 0,
                    RoundType = 0,
                    ManualDiscount = li.ManualDiscount,
                    ManualDiscountPercent = li.ManualDiscountPercent,
                    Point = 0,
                    CurrentPrice = li.CurrentPrice,
                    OrderQuantity = 0,
                    ServiceAmount = 0,
                    StatusId = null,
                    IsTaxAsDiscount = false,
                    InvoiceDate = generateDateOnly
                }).ToList() ?? new List<Infrastructure.Entities.SaleInvoiceLineItem>(),

                // --- پرداخت‌ها ---
                SaleInvoiceTenders = invoice.InvoiceTenders?.Select(t => new Infrastructure.Entities.SaleInvoiceTender
                {
                    BookerStoreId = t.BookerStoreId,
                    BookerWorkstationId = generateBookerWorkstation,
                    InvoiceId = generateInvoiceId,
                    TenderId = t.TenderId.GetValueOrDefault(),
                    Amount = t.Amount,
                    CashierId = invoice.CreationUser,
                    LineItemId = t.LineItemId,
                    DueDate = generateNow,
                    PaymentDate = generateNow,
                    ExchangeAmount = 1,
                    ReturnAmount = t.ReturnAmount
                }).ToList() ?? new List<Infrastructure.Entities.SaleInvoiceTender>(),

                // --- تحویل‌ها ---
                SaleItemDeliveries = invoice.InvoiceItemDeliveries?.Select(d => new Infrastructure.Entities.SaleItemDelivery
                {
                    BookerStoreId = d.BookerStoreId,
                    BookerWorkstationId = generateBookerWorkstation,
                    InvoiceId = generateInvoiceId,
                    DeliveryId = 1,
                    DeliveryDate = generateNow,
                    Address = d.Address,
                    Tell = d.Tell,
                    Mobile = d.Mobile,
                    Longitude = d.Longitude,
                    Latitude = d.Latitude,
                    InstallDate = generateNow,
                    ConfirmDeliveryDate = generateNow,
                    Floor = 0,
                    Elevator = false,
                    DeliveryPersonId = null,
                    InstallPersonId = null,
                    DeliveryPrice = d.DeliveryPrice,
                    InstallPrice = 0,
                    StatusId = 336,
                    Description = d.Description,
                    InstallDescription = null,
                    DeliveryRate = 0,
                    InstallRate = 0,
                    IsDeliver = true,
                    IsInstall = false,
                    DeliveryTypeId = 454,
                    ShippingCompany = null,
                    DriverName = null,
                    FareAmount = 0,
                    ShippingDate = generateNow,
                    ShippingNumber = null,
                    CertificateNumber = null ,
                    CarType = null,
                    CarTag = null,
                    FinanceApprove = false,
                    FinanceApproveUser = null,
                    FinanceApproveDate = null,
                    IsInstallRequire = false,
                    DeliveryApproveUser = null,
                    DeliveryApproveDate = null,
                    InstallApproveUser = null,
                    InstallApproveDate = null,
                    ExtrernalCode = null
                }).ToList() ?? new List<Infrastructure.Entities.SaleItemDelivery>()
            };

            // ✅ ذخیره
            _context.SaleInvoices.Add(efEntity);
            await _context.SaveChangesAsync();
        }


        public async Task<SaleInvoiceDto?> GetByIdAsync(Guid invoiceId)
        {
            var entity = await _context.SaleInvoices
                .Include(i => i.SaleInvoiceLineItems)
                .Include(i => i.SaleInvoiceTenders)
                .Include(i => i.SaleItemDeliveries) // 👈 اضافه شد
                .FirstOrDefaultAsync(i => i.InvoiceId == invoiceId);

            if (entity == null)
                return null;

            var domainModel = new SaleInvoiceDto
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

                InvoiceLineItems = entity.SaleInvoiceLineItems?.Select(li => new SaleInvoiceLineItemDto
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

                InvoiceTenders = entity.SaleInvoiceTenders?.Select(t => new SaleinvoiceTenderDto
                {
                    BookerStoreId = t.BookerStoreId,
                    BookerWorkstationId = t.BookerWorkstationId,
                    InvoiceId = t.InvoiceId,
                    TenderId = t.TenderId,
                    Amount = t.Amount,
                    CashierId = t.CashierId,
                    LineItemId = t.LineItemId,
                    DueDate = t.DueDate,
                    PaymentDate = t.PaymentDate,
                    ExchangeAmount = t.ExchangeAmount,
                    ReturnAmount = t.ReturnAmount
                }).ToList() ?? new(),

                InvoiceItemDeliveries = entity.SaleItemDeliveries?.Select(d => new SaleItemDelivery
                {
                    BookerStoreId = d.BookerStoreId,
                    BookerWorkstationId = d.BookerWorkstationId,
                    InvoiceId = d.InvoiceId,
                    DeliveryId = d.DeliveryId,
                    DeliveryDate = d.DeliveryDate,
                    Address = d.Address,
                    Tell = d.Tell,
                    Mobile = d.Mobile,
                    Longitude = d.Longitude,
                    Latitude = d.Latitude,
                    InstallDate = d.InstallDate,
                    ConfirmDeliveryDate = d.ConfirmDeliveryDate,
                    Floor = d.Floor,
                    Elevator = d.Elevator,
                    DeliveryPersonId = d.DeliveryPersonId,
                    InstallPersonId = d.InstallPersonId,
                    DeliveryPrice = d.DeliveryPrice,
                    InstallPrice = d.InstallPrice,
                    StatusId = d.StatusId,
                    Description = d.Description,
                    InstallDescription = d.InstallDescription,
                    DeliveryRate = d.DeliveryRate,
                    InstallRate = d.InstallRate,
                    IsDeliver = d.IsDeliver,
                    IsInstall = d.IsInstall,
                    DeliveryTypeId = d.DeliveryTypeId,
                    ShippingCompany = d.ShippingCompany,
                    DriverName = d.DriverName,
                    FareAmount = d.FareAmount,                    
                    ShippingNumber = d.ShippingNumber,
                    CertificateNumber = d.CertificateNumber,
                    CarType =null ,
                    CarTag = null ,
                    FinanceApprove = false,
                    FinanceApproveUser = null ,
                    FinanceApproveDate = null,
                    IsInstallRequire = false,
                    DeliveryApproveUser = null,
                    DeliveryApproveDate = null ,
                    InstallApproveUser = null ,
                    InstallApproveDate = null ,
                    ExtrernalCode = null 
                }).ToList() ?? new()
            };

            return domainModel;
        }




    }




}

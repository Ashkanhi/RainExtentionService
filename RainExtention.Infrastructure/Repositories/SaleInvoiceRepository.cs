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
 

        public async Task AddAsync(Domain.Entities.SaleInvoice invoice)
        {
            var efEntity = new Infrastructure.Entities.SaleInvoice
            {
                BookerStoreId = invoice.BookerStoreId,
                BookerWorkstationId = invoice.BookerWorkstationId,
                InvoiceId = invoice.InvoiceId,
                InvoiceDate = invoice.InvoiceDate,
                BusinessDate = invoice.BusinessDate,
                InvoiceNumber = invoice.InvoiceNumber,
                InvoiceTypeId = invoice.InvoiceTypeId,
                CustomerId = invoice.CustomerId,
                ExpectedAmount = invoice.ExpectedAmount,
                CreationUser = invoice.CreationUser,
                CreationDate = invoice.CreationDate,
                ModifyUser = invoice.ModifyUser,
                ModifyDate = invoice.ModifyDate,
                AuthorizeUser = invoice.AuthorizeUser,
                IsOnlineSale = invoice.IsOnlineSale,
                ScanCount = invoice.ScanCount,
                InvoiceTime = invoice.InvoiceTime,
                SaleChannelId = invoice.SaleChannelId,
                StockId = invoice.StockId,

                SaleInvoiceLineItems = invoice.InvoiceLineItems?.Select(li => new Infrastructure.Entities.SaleInvoiceLineItem
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

                SaleInvoiceTenders = invoice.InvoiceTenders?.Select(t => new Infrastructure.Entities.SaleInvoiceTender
                {
                    BookerStoreId = t.BookerStoreId,
                    BookerWorkstationId = t.BookerWorkstationId,
                    InvoiceId = t.InvoiceId,
                    TenderId = t.TenderId.GetValueOrDefault(),
                    Amount = t.Amount,
                    CashierId = t.CashierId,
                    LineItemId = t.LineItemId,
                    DueDate = t.DueDate,
                    PaymentDate = t.PaymentDate,
                    ExchangeAmount = t.ExchangeAmount,
                    ReturnAmount = t.ReturnAmount
                }).ToList() ?? new(),

                SaleItemDeliveries = invoice.InvoiceItemDeliveries?.Select(d => new Infrastructure.Entities.SaleItemDelivery
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
                    ShippingDate = d.ShippingDate,
                    ShippingNumber = d.ShippingNumber,
                    CertificateNumber = d.CertificateNumber,
                    CarType = d.CarType,
                    CarTag = d.CarTag,
                    FinanceApprove = d.FinanceApprove,
                    FinanceApproveUser = d.FinanceApproveUser,
                    FinanceApproveDate = d.FinanceApproveDate,
                    IsInstallRequire = d.IsInstallRequire,
                    DeliveryApproveUser = d.DeliveryApproveUser,
                    DeliveryApproveDate = d.DeliveryApproveDate,
                    InstallApproveUser = d.InstallApproveUser,
                    InstallApproveDate = d.InstallApproveDate,
                    ExtrernalCode = d.ExtrernalCode
                }).ToList() ?? new()
            };

            _context.SaleInvoices.Add(efEntity);
            await _context.SaveChangesAsync();
        }


        public async Task<SaleInvoice?> GetByIdAsync(Guid invoiceId)
        {
            var entity = await _context.SaleInvoices
                .Include(i => i.SaleInvoiceLineItems)
                .Include(i => i.SaleInvoiceTenders)
                .Include(i => i.SaleItemDeliveries) // 👈 اضافه شد
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
                    ShippingDate = d.ShippingDate,
                    ShippingNumber = d.ShippingNumber,
                    CertificateNumber = d.CertificateNumber,
                    CarType = d.CarType,
                    CarTag = d.CarTag,
                    FinanceApprove = d.FinanceApprove,
                    FinanceApproveUser = d.FinanceApproveUser,
                    FinanceApproveDate = d.FinanceApproveDate,
                    IsInstallRequire = d.IsInstallRequire,
                    DeliveryApproveUser = d.DeliveryApproveUser,
                    DeliveryApproveDate = d.DeliveryApproveDate,
                    InstallApproveUser = d.InstallApproveUser,
                    InstallApproveDate = d.InstallApproveDate,
                    ExtrernalCode = d.ExtrernalCode
                }).ToList() ?? new()
            };

            return domainModel;
        }




    }




}

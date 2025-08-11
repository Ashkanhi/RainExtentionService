using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainExtention.Domain.Entities;
using RainExtention.Infrastructure.Context;
using RainExtention.Domain.Interface;

namespace RainExtention.Infrastructure.Repositories
{
    public class StockDocumentRepository : IStockDocumentRepository
    {
        private readonly ApplicationDbContext _context;

        public StockDocumentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(StockDocument document)
        {
            var efEntity = new RainExtention.Infrastructure.Entities.StockDocument
            {
                BookerStoreId = document.BookerStoreId,
                BookerWorkstationId = document.BookerWorkstationId,
                DocumentId = document.DocumentId,
                DocumentCode = document.DocumentCode,
                BusinessDate = document.BusinessDate,
                DocumentDate = document.DocumentDate,
                DocumentTypeId = document.DocumentTypeId,
                SupplierId = document.SupplierId,
                SourceStockId = document.SourceStockId,
                TargetStockId = document.TargetStockId,
                Comment = document.Comment,
                StatusId = document.StatusId,
                ApproveUser = document.ApproveUser,
                ApproveDate = document.ApproveDate,
                VoidUser = document.VoidUser,
                VoidDate = document.VoidDate,
                CreationUser = document.CreationUser,
                CreationDate = document.CreationDate,
                FinanceApprove = document.FinanceApprove,
                FinanceApproveUser = document.FinanceApproveUser,
                FinanceApproveDate = document.FinanceApproveDate,
                InvoiceNumber = document.InvoiceNumber,
                ExpectedRecieveDate = document.ExpectedRecieveDate,
                ThresholdAmount = document.ThresholdAmount,
                IsBeginDocument = document.IsBeginDocument,
                ThirdPartyId = document.ThirdPartyId,
                FinanceDocumentCode = document.FinanceDocumentCode,
                FinanceDocument = document.FinanceDocument,
                ReasonId = document.ReasonId,
                DepartmentId = document.DepartmentId,
                UsageTypeId = document.UsageTypeId,
                CalculateTax = document.CalculateTax,
                CalculateDiscount = document.CalculateDiscount,
                FinancialApproveUser = document.FinancialApproveUser,
                FinancialApproveDate = document.FinancialApproveDate,
                PaymentApprove = document.PaymentApprove,
                PaymentDate = document.PaymentDate,
                PaymentAmount = document.PaymentAmount,
                AllowReserveQuantity = document.AllowReserveQuantity,
                IsComplete = document.IsComplete,
                TotalQuantity = document.TotalQuantity,
                TotalAmount = document.TotalAmount,
                ExchangeAmount = document.ExchangeAmount,
                CostWithTax = document.CostWithTax,
                CurrencyId = document.CurrencyId,
                VisitorId = document.VisitorId,
                ReferenceNumber = document.ReferenceNumber,
                PartNumber = document.PartNumber,
                DocumentTime = document.DocumentTime,
                SupplierConfirm = document.SupplierConfirm,
                SupplierDescription = document.SupplierDescription,
                VoidDescription = document.VoidDescription
            };

            await _context.StockDocuments.AddAsync(efEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<StockDocument>> GetAllAsync()
        {
            var efEntities = await _context.StockDocuments.ToListAsync();

            return efEntities.Select(e => new StockDocument
            {
                BookerStoreId = e.BookerStoreId,
                BookerWorkstationId = e.BookerWorkstationId,
                DocumentId = e.DocumentId,
                DocumentCode = e.DocumentCode,
                BusinessDate = e.BusinessDate,
                DocumentDate = e.DocumentDate,
                DocumentTypeId = e.DocumentTypeId,
                SupplierId = e.SupplierId,
                SourceStockId = e.SourceStockId,
                TargetStockId = e.TargetStockId,
                Comment = e.Comment,
                StatusId = e.StatusId,
                ApproveUser = e.ApproveUser,
                ApproveDate = e.ApproveDate,
                VoidUser = e.VoidUser,
                VoidDate = e.VoidDate,
                CreationUser = e.CreationUser,
                CreationDate = e.CreationDate,
                FinanceApprove = e.FinanceApprove,
                FinanceApproveUser = e.FinanceApproveUser,
                FinanceApproveDate = e.FinanceApproveDate,
                InvoiceNumber = e.InvoiceNumber,
                ExpectedRecieveDate = e.ExpectedRecieveDate,
                ThresholdAmount = e.ThresholdAmount,
                IsBeginDocument = e.IsBeginDocument,
                ThirdPartyId = e.ThirdPartyId,
                FinanceDocumentCode = e.FinanceDocumentCode,
                FinanceDocument = e.FinanceDocument,
                ReasonId = e.ReasonId,
                DepartmentId = e.DepartmentId,
                UsageTypeId = e.UsageTypeId,
                CalculateTax = e.CalculateTax,
                CalculateDiscount = e.CalculateDiscount,
                FinancialApproveUser = e.FinancialApproveUser,
                FinancialApproveDate = e.FinancialApproveDate,
                PaymentApprove = e.PaymentApprove,
                PaymentDate = e.PaymentDate,
                PaymentAmount = e.PaymentAmount,
                AllowReserveQuantity = e.AllowReserveQuantity,
                IsComplete = e.IsComplete,
                TotalQuantity = e.TotalQuantity,
                TotalAmount = e.TotalAmount,
                ExchangeAmount = e.ExchangeAmount,
                CostWithTax = e.CostWithTax,
                CurrencyId = e.CurrencyId,
                VisitorId = e.VisitorId,
                ReferenceNumber = e.ReferenceNumber,
                PartNumber = e.PartNumber,
                DocumentTime = e.DocumentTime,
                SupplierConfirm = e.SupplierConfirm,
                SupplierDescription = e.SupplierDescription,
                VoidDescription = e.VoidDescription
            }).ToList();
        }

        public async Task<StockDocument?> GetByIdAsync(Guid documentId)
        {
            var efEntity = await _context.StockDocuments.FirstOrDefaultAsync(sd => sd.DocumentId == documentId);
            if (efEntity == null) return null;

            return new StockDocument
            {
                BookerStoreId = efEntity.BookerStoreId,
                BookerWorkstationId = efEntity.BookerWorkstationId,
                DocumentId = efEntity.DocumentId,
                DocumentCode = efEntity.DocumentCode,
                BusinessDate = efEntity.BusinessDate,
                DocumentDate = efEntity.DocumentDate,
                DocumentTypeId = efEntity.DocumentTypeId,
                SupplierId = efEntity.SupplierId,
                SourceStockId = efEntity.SourceStockId,
                TargetStockId = efEntity.TargetStockId,
                Comment = efEntity.Comment,
                StatusId = efEntity.StatusId,
                ApproveUser = efEntity.ApproveUser,
                ApproveDate = efEntity.ApproveDate,
                VoidUser = efEntity.VoidUser,
                VoidDate = efEntity.VoidDate,
                CreationUser = efEntity.CreationUser,
                CreationDate = efEntity.CreationDate,
                FinanceApprove = efEntity.FinanceApprove,
                FinanceApproveUser = efEntity.FinanceApproveUser,
                FinanceApproveDate = efEntity.FinanceApproveDate,
                InvoiceNumber = efEntity.InvoiceNumber,
                ExpectedRecieveDate = efEntity.ExpectedRecieveDate,
                ThresholdAmount = efEntity.ThresholdAmount,
                IsBeginDocument = efEntity.IsBeginDocument,
                ThirdPartyId = efEntity.ThirdPartyId,
                FinanceDocumentCode = efEntity.FinanceDocumentCode,
                FinanceDocument = efEntity.FinanceDocument,
                ReasonId = efEntity.ReasonId,
                DepartmentId = efEntity.DepartmentId,
                UsageTypeId = efEntity.UsageTypeId,
                CalculateTax = efEntity.CalculateTax,
                CalculateDiscount = efEntity.CalculateDiscount,
                FinancialApproveUser = efEntity.FinancialApproveUser,
                FinancialApproveDate = efEntity.FinancialApproveDate,
                PaymentApprove = efEntity.PaymentApprove,
                PaymentDate = efEntity.PaymentDate,
                PaymentAmount = efEntity.PaymentAmount,
                AllowReserveQuantity = efEntity.AllowReserveQuantity,
                IsComplete = efEntity.IsComplete,
                TotalQuantity = efEntity.TotalQuantity,
                TotalAmount = efEntity.TotalAmount,
                ExchangeAmount = efEntity.ExchangeAmount,
                CostWithTax = efEntity.CostWithTax,
                CurrencyId = efEntity.CurrencyId,
                VisitorId = efEntity.VisitorId,
                ReferenceNumber = efEntity.ReferenceNumber,
                PartNumber = efEntity.PartNumber,
                DocumentTime = efEntity.DocumentTime,
                SupplierConfirm = efEntity.SupplierConfirm,
                SupplierDescription = efEntity.SupplierDescription,
                VoidDescription = efEntity.VoidDescription
            };
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

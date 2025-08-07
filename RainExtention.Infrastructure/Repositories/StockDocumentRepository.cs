using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Entities;
using RainExtention.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using RainExtention.Domain;

namespace RainExtention.Infrastructure.Repositories
{
    public class StockDocumentRepository : IStockDocumentRepository
    {
        private readonly ApplicationDbContext _context;
        public StockDocumentRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public System.Threading.Tasks.Task AddAsync(StockDocument document)
        {
            throw new NotImplementedException();
        }

        public Task<List<StockDocument>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public  async  Task<StockDocument?> GetByIdAsync(Guid documentId)
        {
            var efEntity = await _context.StockDocuments.FirstOrDefaultAsync(sd => sd.DocumentId == documentId);

            if (efEntity == null) return null;

            return new Domain.Entities.StockDocument
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

            //return await _context.StockDocuments.FirstOrDefaultAsync(sd => sd.DocumentId == documentId); 
        }

        public System.Threading.Tasks.Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

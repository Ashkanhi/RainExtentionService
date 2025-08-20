using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Entities
{
    public partial class StockDocument
    {        
        public int BookerStoreId { get; set; }
        public int BookerWorkstationId { get; set; }        
        public Guid DocumentId { get; set; }        
        public string? DocumentCode { get; set; }
        public DateOnly? BusinessDate { get; set; }        
        public DateTime? DocumentDate { get; set; }        
        public int? DocumentTypeId { get; set; }
        public Guid? SupplierId { get; set; }        
        public Guid? SourceStockId { get; set; }        
        public Guid? TargetStockId { get; set; }
        public string? Comment { get; set; }        
        public int? StatusId { get; set; }
        public Guid? ApproveUser { get; set; }        
        public DateTime? ApproveDate { get; set; }
        public Guid? VoidUser { get; set; }        
        public DateTime? VoidDate { get; set; }
        public Guid? CreationUser { get; set; }        
        public DateTime? CreationDate { get; set; }
        public bool? FinanceApprove { get; set; }
        public Guid? FinanceApproveUser { get; set; }        
        public DateTime? FinanceApproveDate { get; set; }        
        public string? InvoiceNumber { get; set; }        
        public DateTime? ExpectedRecieveDate { get; set; }        
        public decimal? ThresholdAmount { get; set; }
        public bool? IsBeginDocument { get; set; }        
        public Guid? ThirdPartyId { get; set; }
        public string? FinanceDocumentCode { get; set; }

        public bool? FinanceDocument { get; set; }        
        public int? ReasonId { get; set; }
        public Guid? DepartmentId { get; set; }
        public int? UsageTypeId { get; set; }
        public bool? CalculateTax { get; set; }
        public bool? CalculateDiscount { get; set; }
        public Guid? FinancialApproveUser { get; set; }        
        public DateTime? FinancialApproveDate { get; set; }
        public bool? PaymentApprove { get; set; }
        public DateTime? PaymentDate { get; set; }        
        public decimal? PaymentAmount { get; set; }
        public bool? AllowReserveQuantity { get; set; }
        public bool? IsComplete { get; set; }        
        public decimal? TotalQuantity { get; set; }        
        public decimal? TotalAmount { get; set; }        
        public decimal? ExchangeAmount { get; set; }
        public bool? CostWithTax { get; set; }        
        public int? CurrencyId { get; set; }        
        public Guid? VisitorId { get; set; }
        public string? ReferenceNumber { get; set; }        
        public string? PartNumber { get; set; }        
        public TimeOnly? DocumentTime { get; set; }
        public bool? SupplierConfirm { get; set; }        
        public string? SupplierDescription { get; set; }        
        public string? VoidDescription { get; set; }
        
        /*
        public virtual User? ApproveUserNavigation { get; set; }        
        public virtual User? CreationUserNavigation { get; set; }
        
        public virtual Currency? Currency { get; set; }
        
        public virtual Dictionary? DocumentType { get; set; }
        
        public virtual User? FinanceApproveUserNavigation { get; set; }
        
        public virtual Stock? SourceStock { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("StockDocumentStatuses")]
        public virtual Dictionary? Status { get; set; }

        [InverseProperty("StockDocument")]
        public virtual ICollection<StockDocumentAttachment> StockDocumentAttachments { get; set; } = new List<StockDocumentAttachment>();

        [InverseProperty("StockDocument")]
        public virtual ICollection<StockDocumentCostModifierReference> StockDocumentCostModifierReferences { get; set; } = new List<StockDocumentCostModifierReference>();
        public virtual ICollection<StockDocumentCostModifier> StockDocumentCostModifiers { get; set; } = new List<StockDocumentCostModifier>();
        
        public virtual StockDocumentCustomField? StockDocumentCustomField { get; set; }
        public virtual ICollection<StockDocumentLineItem> StockDocumentLineItems { get; set; } = new List<StockDocumentLineItem>();        
        public virtual ICollection<StockDocumentPayment> StockDocumentPayments { get; set; } = new List<StockDocumentPayment>();        
        public virtual StockDocumentReference? StockDocumentReference { get; set; }
        public virtual Supplier? Supplier { get; set; }        
        public virtual ICollection<SupplierSaleLineItem> SupplierSaleLineItems { get; set; } = new List<SupplierSaleLineItem>();        
        public virtual Stock? TargetStock { get; set; }        
        public virtual Visitor? Visitor { get; set; }
        public virtual User? VoidUserNavigation { get; set; }
        public virtual Workstation Workstation { get; set; } = null!;
        */
    }
}

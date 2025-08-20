using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId")]
[Table("StockDocument")]
[Index("DepartmentId", Name = "IX_DepartmentID")]
[Index("DocumentCode", Name = "IX_DocumentCode")]
[Index("DocumentTypeId", Name = "IX_DocumentType")]
[Index("DocumentTypeId", "StatusId", Name = "IX_DocumentType_Status")]
[Index("FinanceDocument", Name = "IX_FinanceDocument")]
[Index("IsBeginDocument", Name = "IX_IsBeginDocument")]
[Index("PaymentApprove", Name = "IX_PaymentApprove")]
[Index("ReasonId", Name = "IX_ReasonID")]
[Index("SourceStockId", Name = "IX_SourceStock")]
[Index("StatusId", Name = "IX_Status")]
[Index("DocumentDate", Name = "IX_StockDate")]
[Index("DocumentCode", Name = "IX_StockDocumentCode")]
[Index("SupplierId", Name = "IX_SupplierID")]
[Index("TargetStockId", Name = "IX_TargetStock")]
[Index("ThirdPartyId", Name = "IX_ThirdPartyID")]
[Index("UsageTypeId", Name = "IX_UsageTypeID")]
public partial class StockDocument
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    public DateOnly? BusinessDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [Column("DocumentTypeID")]
    public int? DocumentTypeId { get; set; }

    [Column("SupplierID")]
    public Guid? SupplierId { get; set; }

    [Column("SourceStockID")]
    public Guid? SourceStockId { get; set; }

    [Column("TargetStockID")]
    public Guid? TargetStockId { get; set; }

    public string? Comment { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public bool? FinanceApprove { get; set; }

    public Guid? FinanceApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinanceApproveDate { get; set; }

    [StringLength(50)]
    public string? InvoiceNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedRecieveDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ThresholdAmount { get; set; }

    public bool? IsBeginDocument { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [StringLength(50)]
    public string? FinanceDocumentCode { get; set; }

    public bool? FinanceDocument { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column("DepartmentID")]
    public Guid? DepartmentId { get; set; }

    [Column("UsageTypeID")]
    public int? UsageTypeId { get; set; }

    public bool? CalculateTax { get; set; }

    public bool? CalculateDiscount { get; set; }

    public Guid? FinancialApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinancialApproveDate { get; set; }

    public bool? PaymentApprove { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PaymentAmount { get; set; }

    public bool? AllowReserveQuantity { get; set; }

    public bool? IsComplete { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalQuantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExchangeAmount { get; set; }

    public bool? CostWithTax { get; set; }

    [Column("CurrencyID")]
    public int? CurrencyId { get; set; }

    [Column("VisitorID")]
    public Guid? VisitorId { get; set; }

    [StringLength(20)]
    public string? ReferenceNumber { get; set; }

    [StringLength(20)]
    public string? PartNumber { get; set; }

    [Precision(3)]
    public TimeOnly? DocumentTime { get; set; }

    public bool? SupplierConfirm { get; set; }

    [StringLength(255)]
    public string? SupplierDescription { get; set; }

    [StringLength(255)]
    public string? VoidDescription { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("StockDocumentApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("StockDocumentCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("StockDocuments")]
    public virtual Currency? Currency { get; set; }

    [ForeignKey("DocumentTypeId")]
    [InverseProperty("StockDocumentDocumentTypes")]
    public virtual Dictionary? DocumentType { get; set; }

    [ForeignKey("FinanceApproveUser")]
    [InverseProperty("StockDocumentFinanceApproveUserNavigations")]
    public virtual User? FinanceApproveUserNavigation { get; set; }

    [ForeignKey("SourceStockId")]
    [InverseProperty("StockDocumentSourceStocks")]
    public virtual Stock? SourceStock { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("StockDocumentStatuses")]
    public virtual Dictionary? Status { get; set; }

    [InverseProperty("StockDocument")]
    public virtual ICollection<StockDocumentAttachment> StockDocumentAttachments { get; set; } = new List<StockDocumentAttachment>();

    [InverseProperty("StockDocument")]
    public virtual ICollection<StockDocumentCostModifierReference> StockDocumentCostModifierReferences { get; set; } = new List<StockDocumentCostModifierReference>();

    [InverseProperty("StockDocument")]
    public virtual ICollection<StockDocumentCostModifier> StockDocumentCostModifiers { get; set; } = new List<StockDocumentCostModifier>();

    [InverseProperty("StockDocument")]
    public virtual StockDocumentCustomField? StockDocumentCustomField { get; set; }

    [InverseProperty("StockDocument")]
    public virtual ICollection<StockDocumentLineItem> StockDocumentLineItems { get; set; } = new List<StockDocumentLineItem>();

    [InverseProperty("StockDocument")]
    public virtual ICollection<StockDocumentPayment> StockDocumentPayments { get; set; } = new List<StockDocumentPayment>();

    [InverseProperty("StockDocument")]
    public virtual StockDocumentReference? StockDocumentReference { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("StockDocuments")]
    public virtual Supplier? Supplier { get; set; }

    [InverseProperty("StockDocument")]
    public virtual ICollection<SupplierSaleLineItem> SupplierSaleLineItems { get; set; } = new List<SupplierSaleLineItem>();

    [ForeignKey("TargetStockId")]
    [InverseProperty("StockDocumentTargetStocks")]
    public virtual Stock? TargetStock { get; set; }

    [ForeignKey("VisitorId")]
    [InverseProperty("StockDocuments")]
    public virtual Visitor? Visitor { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("StockDocumentVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId")]
    [InverseProperty("StockDocuments")]
    public virtual Workstation Workstation { get; set; } = null!;
}

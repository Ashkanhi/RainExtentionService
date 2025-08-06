using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class StockDocumentView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

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

    [StringLength(50)]
    public string? DocumentType { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(101)]
    public string? SupplierName { get; set; }

    [StringLength(100)]
    public string? ThirdPartyName { get; set; }

    [StringLength(100)]
    public string? VisitorName { get; set; }

    public int? DocumentLanguage { get; set; }

    public int? StatusLanguage { get; set; }

    [Column("TargetStoreID")]
    public int? TargetStoreId { get; set; }

    [StringLength(50)]
    public string? TargetStock { get; set; }

    [Column("SourceStoreID")]
    public int? SourceStoreId { get; set; }

    [StringLength(50)]
    public string? SourceStock { get; set; }

    [StringLength(100)]
    public string? DepartmentName { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CreationUserName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ApproveUserName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string FinanceApproveUserName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ReferDocumentCode { get; set; } = null!;
}

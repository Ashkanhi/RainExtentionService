using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class ProductionDocumentView
{
    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [StringLength(50)]
    public string? DocumentCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    [Column("StepID")]
    public Guid? StepId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    public Guid? CreationUser { get; set; }

    public DateOnly? CreationDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public bool? FinanceApprove { get; set; }

    public Guid? FinanceApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinanceApproveDate { get; set; }

    public Guid? VoidUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    [Column("ReferDocumentID")]
    public Guid? ReferDocumentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    public int? PersonCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public bool? QualityControlStatus { get; set; }

    [Column("QCUser")]
    public Guid? Qcuser { get; set; }

    [Column("QCTime", TypeName = "datetime")]
    public DateTime? Qctime { get; set; }

    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    public bool? FinanceDocument { get; set; }

    [StringLength(50)]
    public string? FinanceDocumentCode { get; set; }

    public Guid? FinancialApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinancialApproveDate { get; set; }

    [Column("ProductID")]
    public Guid? ProductId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ProductQuantity { get; set; }

    [Column("BatchID")]
    public Guid? BatchId { get; set; }

    [Column("OrderID")]
    public Guid? OrderId { get; set; }

    [Column("BomID")]
    public Guid? BomId { get; set; }

    [StringLength(100)]
    public string? StepName { get; set; }

    [StringLength(50)]
    public string? StockName { get; set; }

    [StringLength(255)]
    public string? ProductName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(50)]
    public string? BatchNumber { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Column("SourceStockID")]
    public Guid? SourceStockId { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? ApproveUserName { get; set; }

    [StringLength(50)]
    public string? VoidUserName { get; set; }

    [Column("AllowQC")]
    public bool? AllowQc { get; set; }
}

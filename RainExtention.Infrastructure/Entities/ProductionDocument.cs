using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Table("ProductionDocument")]
public partial class ProductionDocument
{
    [Key]
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

    [ForeignKey("ApproveUser")]
    [InverseProperty("ProductionDocumentApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("BatchId")]
    [InverseProperty("ProductionDocuments")]
    public virtual ProductionSeries? Batch { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("ProductionDocumentCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("FinanceApproveUser")]
    [InverseProperty("ProductionDocumentFinanceApproveUserNavigations")]
    public virtual User? FinanceApproveUserNavigation { get; set; }

    [InverseProperty("ReferDocument")]
    public virtual ICollection<ProductionDocument> InverseReferDocument { get; set; } = new List<ProductionDocument>();

    [ForeignKey("OrderId")]
    [InverseProperty("ProductionDocuments")]
    public virtual ProductionOrder? Order { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductionDocuments")]
    public virtual Item? Product { get; set; }

    [InverseProperty("Document")]
    public virtual ProductionDocumentCustomField? ProductionDocumentCustomField { get; set; }

    [InverseProperty("Document")]
    public virtual ICollection<ProductionDocumentLineItem> ProductionDocumentLineItems { get; set; } = new List<ProductionDocumentLineItem>();

    [ForeignKey("ReferDocumentId")]
    [InverseProperty("InverseReferDocument")]
    public virtual ProductionDocument? ReferDocument { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("ProductionDocuments")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("StepId")]
    [InverseProperty("ProductionDocuments")]
    public virtual ProductionStep? Step { get; set; }

    [ForeignKey("StockId")]
    [InverseProperty("ProductionDocuments")]
    public virtual Stock? Stock { get; set; }

    [ForeignKey("ThirdPartyId")]
    [InverseProperty("ProductionDocuments")]
    public virtual ThirdParty? ThirdParty { get; set; }

    [ForeignKey("VoidUser")]
    [InverseProperty("ProductionDocumentVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }
}

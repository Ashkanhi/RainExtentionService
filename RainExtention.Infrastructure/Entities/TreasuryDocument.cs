using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId")]
[Table("TreasuryDocument")]
public partial class TreasuryDocument
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

    [Column("DocumentTypeID")]
    public int? DocumentTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BusinessDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [Column("ThirdPartyID")]
    public Guid? ThirdPartyId { get; set; }

    [Column("ReasonID")]
    public int? ReasonId { get; set; }

    [Column("RepositoryID")]
    public int? RepositoryId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public Guid? VoidUser { get; set; }

    [StringLength(50)]
    public string? FinanceDocumentCode { get; set; }

    public bool? FinanceDocument { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("TreasuryDocumentApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("TreasuryDocumentCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("DocumentTypeId")]
    [InverseProperty("TreasuryDocumentDocumentTypes")]
    public virtual Dictionary? DocumentType { get; set; }

    [ForeignKey("ReasonId")]
    [InverseProperty("TreasuryDocuments")]
    public virtual Reason? Reason { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("TreasuryDocumentStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("ThirdPartyId")]
    [InverseProperty("TreasuryDocuments")]
    public virtual ThirdParty? ThirdParty { get; set; }

    [InverseProperty("TreasuryDocument")]
    public virtual TreasuryDocumentCustomField? TreasuryDocumentCustomField { get; set; }

    [InverseProperty("TreasuryDocument")]
    public virtual ICollection<TreasuryDocumentLineItem> TreasuryDocumentLineItems { get; set; } = new List<TreasuryDocumentLineItem>();

    [ForeignKey("VoidUser")]
    [InverseProperty("TreasuryDocumentVoidUserNavigations")]
    public virtual User? VoidUserNavigation { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId")]
    [InverseProperty("TreasuryDocuments")]
    public virtual Workstation Workstation { get; set; } = null!;

    [ForeignKey("TreasuryBookerStoreId, TreasuryBookerWorkstationId, TreasuryDocumentId")]
    [InverseProperty("TreasuryDocuments")]
    public virtual ICollection<SaleInvoicePartialPayment> SaleInvoicePartialPayments { get; set; } = new List<SaleInvoicePartialPayment>();
}

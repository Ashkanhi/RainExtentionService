using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId")]
[Table("FinancialDocument")]
public partial class FinancialDocument
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

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [StringLength(50)]
    public string? ReferenceNumber { get; set; }

    [Column("FinancialYearID")]
    public int? FinancialYearId { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? CreditAmount { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? DebitAmount { get; set; }

    [Column("DocumentTypeID")]
    public int? DocumentTypeId { get; set; }

    public bool? IsSystemGenerated { get; set; }

    [Column("StatusID")]
    public int? StatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    public Guid? CreationUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TempDate { get; set; }

    public Guid? TempUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApproveDate { get; set; }

    public Guid? ApproveUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [ForeignKey("ApproveUser")]
    [InverseProperty("FinancialDocumentApproveUserNavigations")]
    public virtual User? ApproveUserNavigation { get; set; }

    [ForeignKey("CreationUser")]
    [InverseProperty("FinancialDocumentCreationUserNavigations")]
    public virtual User? CreationUserNavigation { get; set; }

    [ForeignKey("DocumentTypeId")]
    [InverseProperty("FinancialDocumentDocumentTypes")]
    public virtual Dictionary? DocumentType { get; set; }

    [InverseProperty("FinancialDocument")]
    public virtual ICollection<FinancialDocumentLineItem> FinancialDocumentLineItems { get; set; } = new List<FinancialDocumentLineItem>();

    [ForeignKey("FinancialYearId")]
    [InverseProperty("FinancialDocuments")]
    public virtual FinancialYear? FinancialYear { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("FinancialDocumentModifyUserNavigations")]
    public virtual User? ModifyUserNavigation { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("FinancialDocumentStatuses")]
    public virtual Dictionary? Status { get; set; }

    [ForeignKey("TempUser")]
    [InverseProperty("FinancialDocumentTempUserNavigations")]
    public virtual User? TempUserNavigation { get; set; }
}

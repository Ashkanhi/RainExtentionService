using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class TreasuryDocumentView
{
    [StringLength(152)]
    public string? DocumentSerial { get; set; }

    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

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

    [StringLength(50)]
    public string? DocumentType { get; set; }

    [StringLength(101)]
    public string? ThirdPartyName { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }

    [StringLength(50)]
    public string? CreationUserName { get; set; }

    [StringLength(50)]
    public string? ApproveUserName { get; set; }

    [StringLength(50)]
    public string? VoidUserName { get; set; }
}

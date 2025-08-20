using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("FinancialDocumentLineItem")]
public partial class FinancialDocumentLineItem
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

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("AccountID")]
    public Guid? AccountId { get; set; }

    [Column("DetailAccountID1")]
    public Guid? DetailAccountId1 { get; set; }

    [Column("DetailAccountID2")]
    public Guid? DetailAccountId2 { get; set; }

    [Column("DetailAccountID3")]
    public Guid? DetailAccountId3 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? DebitAmount { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? CreditAmount { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("FinancialDocumentLineItems")]
    public virtual FinancialDocument FinancialDocument { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("TreasuryDocumentLineItemCheque")]
public partial class TreasuryDocumentLineItemCheque
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

    [StringLength(100)]
    public string? BankName { get; set; }

    [StringLength(100)]
    public string? BranchName { get; set; }

    [StringLength(100)]
    public string? AccountNumber { get; set; }

    [StringLength(100)]
    public string? SerialNumber { get; set; }

    public DateOnly? DueDate { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("TreasuryDocumentLineItemCheque")]
    public virtual TreasuryDocumentLineItem TreasuryDocumentLineItem { get; set; } = null!;
}

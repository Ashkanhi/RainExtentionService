using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class TreasuryDocumentLineItemView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("DocumentID")]
    public Guid DocumentId { get; set; }

    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("TenderID")]
    public int? TenderId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Column("StateID")]
    public int? StateId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [Column("AccountID")]
    public Guid? AccountId { get; set; }

    [Column("StoreID")]
    public int? StoreId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExchangeAmount { get; set; }

    [StringLength(50)]
    public string? TenderName { get; set; }

    public bool? IsPrintable { get; set; }

    [StringLength(100)]
    public string? AccountName { get; set; }
}

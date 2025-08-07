using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("TreasuryDocumentLineItem")]
public partial class TreasuryDocumentLineItem
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

    [ForeignKey("ModifyUser")]
    [InverseProperty("TreasuryDocumentLineItems")]
    public virtual User? ModifyUserNavigation { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("TreasuryDocumentLineItems")]
    public virtual Dictionary? State { get; set; }

    [ForeignKey("TenderId")]
    [InverseProperty("TreasuryDocumentLineItems")]
    public virtual Tender? Tender { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("TreasuryDocumentLineItems")]
    public virtual TreasuryDocument TreasuryDocument { get; set; } = null!;

    [InverseProperty("TreasuryDocumentLineItem")]
    public virtual TreasuryDocumentLineItemCheque? TreasuryDocumentLineItemCheque { get; set; }

    [InverseProperty("TreasuryDocumentLineItem")]
    public virtual ICollection<TreasuryDocumentLineItemDetail> TreasuryDocumentLineItemDetails { get; set; } = new List<TreasuryDocumentLineItemDetail>();
}

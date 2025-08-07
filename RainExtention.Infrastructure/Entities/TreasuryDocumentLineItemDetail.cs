using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId", "Id")]
[Table("TreasuryDocumentLineItemDetail")]
public partial class TreasuryDocumentLineItemDetail
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

    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("StateID")]
    public int? StateId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    public Guid? ModifyUser { get; set; }

    [ForeignKey("ModifyUser")]
    [InverseProperty("TreasuryDocumentLineItemDetails")]
    public virtual User? ModifyUserNavigation { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("TreasuryDocumentLineItemDetails")]
    public virtual Dictionary? State { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("TreasuryDocumentLineItemDetails")]
    public virtual TreasuryDocumentLineItem TreasuryDocumentLineItem { get; set; } = null!;
}

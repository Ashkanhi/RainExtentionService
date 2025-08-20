using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentLineItemReference")]
[Index("ReferStoreId", "ReferWorkstationId", "ReferDocumentId", "ReferLineItemId", Name = "IX_StockDocumentLineItemReference")]
public partial class StockDocumentLineItemReference
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

    [Column("ReferStoreID")]
    public int? ReferStoreId { get; set; }

    [Column("ReferWorkstationID")]
    public int? ReferWorkstationId { get; set; }

    [Column("ReferDocumentID")]
    public Guid? ReferDocumentId { get; set; }

    [Column("ReferLineItemID")]
    public int? ReferLineItemId { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("StockDocumentLineItemReference")]
    public virtual StockDocumentLineItem StockDocumentLineItem { get; set; } = null!;
}

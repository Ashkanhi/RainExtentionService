using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentLineItemExpiration")]
public partial class StockDocumentLineItemExpiration
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

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("StockDocumentLineItemExpiration")]
    public virtual StockDocumentLineItem StockDocumentLineItem { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentLineItemCustomField")]
public partial class StockDocumentLineItemCustomField
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

    [Column("BoxQTY", TypeName = "datetime")]
    public DateTime? BoxQty { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("StockDocumentLineItemCustomField")]
    public virtual StockDocumentLineItem StockDocumentLineItem { get; set; } = null!;
}

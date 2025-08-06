using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentOrderReference")]
public partial class StockDocumentOrderReference
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

    [Column("OrderStoreID")]
    public int? OrderStoreId { get; set; }

    [Column("OrderWorkstationID")]
    public int? OrderWorkstationId { get; set; }

    [Column("OrderID")]
    public Guid? OrderId { get; set; }

    [Column("OrderLineItemID")]
    public int? OrderLineItemId { get; set; }

    [ForeignKey("OrderStoreId, OrderWorkstationId, OrderId, OrderLineItemId")]
    [InverseProperty("StockDocumentOrderReferences")]
    public virtual OrderDocumentLineItem? OrderDocumentLineItem { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("StockDocumentOrderReference")]
    public virtual StockDocumentLineItem StockDocumentLineItem { get; set; } = null!;
}

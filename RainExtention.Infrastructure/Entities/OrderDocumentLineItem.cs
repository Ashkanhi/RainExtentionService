using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "OrderId", "LineItemId")]
[Table("OrderDocumentLineItem")]
public partial class OrderDocumentLineItem
{
    [Key]
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Key]
    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Key]
    [Column("OrderID")]
    public Guid OrderId { get; set; }

    [Key]
    [Column("LineItemID")]
    public int LineItemId { get; set; }

    [Column("ItemID")]
    public Guid? ItemId { get; set; }

    [Column("CustomerID")]
    public Guid? CustomerId { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LastCount { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("OrderDocumentLineItems")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("OrderDocumentLineItems")]
    public virtual Item? Item { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, OrderId")]
    [InverseProperty("OrderDocumentLineItems")]
    public virtual OrderDocument OrderDocument { get; set; } = null!;

    [InverseProperty("OrderDocumentLineItem")]
    public virtual OrderDocumentLineItemCustomField? OrderDocumentLineItemCustomField { get; set; }

    [InverseProperty("OrderDocumentLineItem")]
    public virtual ICollection<StockDocumentOrderReference> StockDocumentOrderReferences { get; set; } = new List<StockDocumentOrderReference>();
}

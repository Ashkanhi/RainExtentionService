using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "OrderId", "LineItemId")]
[Table("OrderDocumentLineItemCustomField")]
public partial class OrderDocumentLineItemCustomField
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

    [ForeignKey("BookerStoreId, BookerWorkstationId, OrderId, LineItemId")]
    [InverseProperty("OrderDocumentLineItemCustomField")]
    public virtual OrderDocumentLineItem OrderDocumentLineItem { get; set; } = null!;
}

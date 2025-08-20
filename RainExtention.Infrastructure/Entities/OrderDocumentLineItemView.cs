using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[Keyless]
public partial class OrderDocumentLineItemView
{
    [Column("BookerStoreID")]
    public int BookerStoreId { get; set; }

    [Column("BookerWorkstationID")]
    public int BookerWorkstationId { get; set; }

    [Column("OrderID")]
    public Guid OrderId { get; set; }

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

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? Barcode { get; set; }

    [StringLength(152)]
    public string? CustomerName { get; set; }

    [StringLength(50)]
    public string? CustomerCode { get; set; }

    [StringLength(15)]
    public string? Mobile { get; set; }

    [Column("LanguageID")]
    public int? LanguageId { get; set; }
}

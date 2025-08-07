using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentLineItemCustomDiscount")]
public partial class StockDocumentLineItemCustomDiscount
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

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount4 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount5 { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("StockDocumentLineItemCustomDiscount")]
    public virtual StockDocumentLineItem StockDocumentLineItem { get; set; } = null!;
}

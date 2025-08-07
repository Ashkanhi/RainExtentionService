using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId", "MonthId")]
[Table("StockDocumentLineItemMonth")]
public partial class StockDocumentLineItemMonth
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
    [Column("MonthID")]
    public int MonthId { get; set; }

    [Column(TypeName = "decimal(38, 9)")]
    public decimal? Quantity { get; set; }

    [ForeignKey("MonthId")]
    [InverseProperty("StockDocumentLineItemMonths")]
    public virtual Dictionary Month { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentLineItemTracking")]
public partial class StockDocumentLineItemTracking
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

    [StringLength(50)]
    public string? Barcode { get; set; }

    [StringLength(50)]
    public string? BatchNumber { get; set; }

    [StringLength(50)]
    public string? PackNumber { get; set; }

    [StringLength(50)]
    public string? PaletteNumber { get; set; }

    [Column("SectionID")]
    public Guid? SectionId { get; set; }

    [Column("StockID")]
    public Guid? StockId { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId, LineItemId")]
    [InverseProperty("StockDocumentLineItemTracking")]
    public virtual StockDocumentLineItem StockDocumentLineItem { get; set; } = null!;
}

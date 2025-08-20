using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId", "LineItemId")]
[Table("StockDocumentAttachment")]
public partial class StockDocumentAttachment
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
    public string? Title { get; set; }

    public byte[]? FileContent { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("StockDocumentAttachments")]
    public virtual StockDocument StockDocument { get; set; } = null!;
}

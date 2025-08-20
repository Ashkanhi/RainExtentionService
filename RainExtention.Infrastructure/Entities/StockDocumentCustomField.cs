using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId")]
[Table("StockDocumentCustomField")]
public partial class StockDocumentCustomField
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

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("StockDocumentCustomField")]
    public virtual StockDocument StockDocument { get; set; } = null!;
}

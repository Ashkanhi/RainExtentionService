using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RainExtention.Infrastructure.Entities;

[PrimaryKey("BookerStoreId", "BookerWorkstationId", "DocumentId")]
[Table("StockDocumentReference")]
[Index("ReferStoreId", "ReferWorkstationId", "ReferDocumentId", Name = "IX_StockDocumentReference")]
public partial class StockDocumentReference
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

    [Column("ReferStoreID")]
    public int? ReferStoreId { get; set; }

    [Column("ReferWorkstationID")]
    public int? ReferWorkstationId { get; set; }

    [Column("ReferDocumentID")]
    public Guid? ReferDocumentId { get; set; }

    [ForeignKey("BookerStoreId, BookerWorkstationId, DocumentId")]
    [InverseProperty("StockDocumentReference")]
    public virtual StockDocument StockDocument { get; set; } = null!;
}
